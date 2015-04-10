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
            if (isMinorCheckBox.Checked) { 
                SqlParameter[] sqlParams = new SqlParameter[3];
                sqlParams[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                sqlParams[0].Value = parentComboBox.SelectedValue;

                sqlParams[1] = new SqlParameter("@FirstName", SqlDbType.VarChar);
                sqlParams[1].Value = txtNewStudentFirstName.Text;

                sqlParams[2] = new SqlParameter("@LastName", SqlDbType.VarChar);
                sqlParams[2].Value = txtNewStudentLastName.Text;

                // and so on

                Program.ExecuteStoredProc("pAddDependent", sqlParams);
            }
            else
            {
                SqlParameter[] sqlParams = new SqlParameter[3];

                sqlParams[1] = new SqlParameter("@FirstName", SqlDbType.VarChar);
                sqlParams[1].Value = txtNewStudentFirstName.Text;

                sqlParams[2] = new SqlParameter("@LastName", SqlDbType.VarChar);
                sqlParams[2].Value = txtNewStudentLastName.Text;

                // and so on
                Program.ExecuteStoredProc("pAddCustomer", sqlParams);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isMinorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            parentComboBox.Enabled = isMinorCheckBox.Checked;
        }
    }
}
