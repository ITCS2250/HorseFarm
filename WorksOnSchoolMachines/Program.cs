using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WorksOnSchoolMachines
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static public SqlConnection ConnectToDB(){
            string ConStr = Properties.Settings.Default.HorseFarmConnectionString;
            SqlConnection conn = new SqlConnection(ConStr);
            conn.Open();
            return conn;
        }
    }
}
