using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HorseFarm
{
    public partial class newRider : Form
    {
        public newRider()
        {
            InitializeComponent();
        }

        private void newRider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Horses' table. You can move, or remove it, as needed.
            this.horsesTableAdapter.Fill(this.horseFarmDataSet1.Horses);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Dependents' table. You can move, or remove it, as needed.
            this.dependentsTableAdapter.Fill(this.horseFarmDataSet1.Dependents);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.horseFarmDataSet1.Customers);

        }

        private void btnNewRiderSubmit_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams = new SqlParameter[1];
            sqlParams[0] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            sqlParams[0].Value = txtNewStudentFirstName.Text;

            Program.ExecuteStoredProc("pAddNewRider", sqlParams);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
