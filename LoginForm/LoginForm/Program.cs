using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Ensure database and tables exist before running
            try
            {
                LoginForm.DatabaseHelper.EnsureDatabaseAndTables();
            }
            catch
            {
                // ignore errors here; UI will show DB errors when saving
            }

            // Start main form directly
            Application.Run(new form_main());
        }
    }
}
