using System;
using System.Data.SqlClient;
using System.Security.Principal;

namespace LoginForm
{
    /// <summary>
    /// Helper to ensure database and required tables exist.
    /// Tries a few common SQL Server connection patterns.
    /// </summary>
    public static class DatabaseHelper
    {
        // Default connection string for the target SQL Server instance.
        // Update this value if your server/instance is different.
        public static string DefaultConnectionString = "Data Source=LAPTOP-6DAOLAME\\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True;TrustServerCertificate=True";

        /// <summary>
        /// Ensure the database and application tables exist. This method will try the provided
        /// connection string, an alternate .\SQLEXPRESS instance, then LocalDB as a last resort.
        /// </summary>
        public static void EnsureDatabaseAndTables(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString)) connectionString = DefaultConnectionString;

            if (TryEnsure(connectionString)) return;

            var alternate = new SqlConnectionStringBuilder(connectionString)
            {
                DataSource = @".\\SQLEXPRESS"
            }.ConnectionString;

            if (TryEnsure(alternate)) return;

            var localdb = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=QLSV_DB;Integrated Security=True";
            TryEnsure(localdb);
        }

        // Internal attempt to create database and tables using the given connection string.
        private static bool TryEnsure(string connectionString)
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(connectionString);
                string database = builder.InitialCatalog;

                // create database if missing (connect to master)
                var masterBuilder = new SqlConnectionStringBuilder(connectionString) { InitialCatalog = "master" };
                using (var conn = new SqlConnection(masterBuilder.ConnectionString))
                {
                    conn.Open();
                    string sqlCreateDb = $"IF DB_ID(N'{database}') IS NULL CREATE DATABASE [{database}];";
                    using (var cmd = new SqlCommand(sqlCreateDb, conn)) cmd.ExecuteNonQuery();
                }

                // create tables if missing
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string createStudents = @"
IF OBJECT_ID(N'dbo.Students', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Students(
        MaSV NVARCHAR(50) NOT NULL PRIMARY KEY,
        HoTen NVARCHAR(200) NULL,
        GioiTinh NVARCHAR(50) NULL,
        NgaySinh DATE NULL,
        Lop NVARCHAR(100) NULL
    );
END
";

                    string createClasses = @"
IF OBJECT_ID(N'dbo.Classes', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Classes(
        MaID NVARCHAR(50) NOT NULL PRIMARY KEY,
        MaLop NVARCHAR(50) NOT NULL,
        TenLop NVARCHAR(200) NULL,
        GhiChu NVARCHAR(500) NULL
    );
END
";

                    using (var cmd = new SqlCommand(createStudents, conn)) cmd.ExecuteNonQuery();
                    using (var cmd = new SqlCommand(createClasses, conn)) cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Attempt to create a server login and database user for the current Windows account.
        /// Requires the executing account to have sufficient privileges on the SQL Server instance.
        /// </summary>
        public static void CreateLoginForCurrentWindowsUser(string connectionString = null)
        {
            if (string.IsNullOrEmpty(connectionString)) connectionString = DefaultConnectionString;

            string account = WindowsIdentity.GetCurrent().Name; // DOMAIN\User

            try
            {
                // create server login if missing
                var masterBuilder = new SqlConnectionStringBuilder(connectionString) { InitialCatalog = "master" };
                using (var conn = new SqlConnection(masterBuilder.ConnectionString))
                {
                    conn.Open();
                    string sqlLogin = $@"IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name = N'{account}')
BEGIN
    EXEC(N'CREATE LOGIN [' + N'{account}' + N'] FROM WINDOWS');
END
";
                    using (var cmd = new SqlCommand(sqlLogin, conn)) cmd.ExecuteNonQuery();
                }

                // create database user and add to db_owner
                var dbBuilder = new SqlConnectionStringBuilder(connectionString);
                string dbname = dbBuilder.InitialCatalog;

                string sql = $@"USE [{dbname}];
IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N'{account}')
BEGIN
    CREATE USER [{account}] FOR LOGIN [{account}];
END
IF NOT EXISTS (
    SELECT 1 FROM sys.database_role_members drm
    JOIN sys.database_principals r ON drm.role_principal_id = r.principal_id
    JOIN sys.database_principals u ON drm.member_principal_id = u.principal_id
    WHERE r.name = N'db_owner' AND u.name = N'{account}')
BEGIN
    EXEC sp_addrolemember N'db_owner', N'{account}';
END
";

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn)) cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // ignore or surface - caller can display
                throw new InvalidOperationException("Could not create server login/database user: " + ex.Message, ex);
            }
        }
    }
}
