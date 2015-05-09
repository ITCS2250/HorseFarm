using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HorseFarm
{

    static class Program
    {
        public static MainScreen mainScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }

        /// <summary>
        /// Returns a connection to the default database defined under Properties.Settings.Default.HorseFarmConnectionString. 
        /// Do not forget to call Close() on the connection object after it has been used.
        /// </summary>
        static public SqlConnection ConnectToDB(){
            string ConStr = Properties.Settings.Default.HorseFarmConnectionString;
            SqlConnection conn = new SqlConnection(ConStr);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Executes a stored procedure with the given parameters.
        /// </summary>
        /// <param name="procName">The name of the stored procedure to be executed.</param>
        /// <param name="parameters">Array containing SqlParameter objects, do not forget to initialize their values.</param>
        static public void ExecuteStoredProc(string procName, SqlParameter[] parameters){
            SqlConnection conn = Program.ConnectToDB();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.Parameters.AddRange(parameters);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

}
