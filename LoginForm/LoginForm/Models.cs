using System;
using System.Data.Linq.Mapping;

namespace LoginForm
{
    [Table(Name = "Students")]
    public class Student
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, DbType = "NVarChar(50)")]
        public string MaSV { get; set; }

        [Column(CanBeNull = true, DbType = "NVarChar(200)")]
        public string HoTen { get; set; }

        [Column(CanBeNull = true, DbType = "NVarChar(50)")]
        public string GioiTinh { get; set; }

        [Column(CanBeNull = true, DbType = "Date")]
        public DateTime? NgaySinh { get; set; }

        [Column(CanBeNull = true, DbType = "NVarChar(100)")]
        public string Lop { get; set; }
    }

    [Table(Name = "Classes")]
    public class Class
    {
        [Column(IsPrimaryKey = true, CanBeNull = false, DbType = "NVarChar(50)")]
        public string MaID { get; set; }

        [Column(CanBeNull = false, DbType = "NVarChar(50)")]
        public string MaLop { get; set; }

        [Column(CanBeNull = true, DbType = "NVarChar(200)")]
        public string TenLop { get; set; }

        [Column(CanBeNull = true, DbType = "NVarChar(500)")]
        public string GhiChu { get; set; }
    }

    public partial class DataClasses1DataContext
    {
        public System.Data.Linq.Table<Student> Students { get { return this.GetTable<Student>(); } }
        public System.Data.Linq.Table<Class> Classes { get { return this.GetTable<Class>(); } }
    }
}
