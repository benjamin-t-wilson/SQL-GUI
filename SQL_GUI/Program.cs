using SQL_GUI.Forms;
using SQL_GUI.Functions;
using System;
using System.Windows.Forms;

namespace SQL_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var connInfo = new SqliteConnStorage();
            connInfo.CreateDatabaseAndTable();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConnectionBox());
        }
    }
}