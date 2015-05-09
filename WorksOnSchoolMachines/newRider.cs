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
            txtZip.MaxLength = 10;
            txtCellPhone.MaxLength = 15;
            txtHomePhone.MaxLength = 15;
            txtHomePhone.MaxLength = 15;
        }

        private void btnNewRiderSubmit_Click(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();

            sqlParams.Add(new SqlParameter("@Prefix", SqlDbType.VarChar));
            sqlParams.Last().Value = cboPrefix.SelectedText;

            sqlParams.Add(new SqlParameter("@FirstName", SqlDbType.VarChar));
            sqlParams.Last().Value = txtNewStudentFirstName.Text;

            sqlParams.Add(new SqlParameter("@LastName", SqlDbType.VarChar));
            sqlParams.Last().Value = txtNewStudentLastName.Text;

            sqlParams.Add(new SqlParameter("@Address", SqlDbType.VarChar));
            sqlParams.Last().Value = txtAddress.Text;

            sqlParams.Add(new SqlParameter("@State", SqlDbType.VarChar));
            sqlParams.Last().Value = cboState.SelectedValue;

            sqlParams.Add(new SqlParameter("@ZIP", SqlDbType.VarChar));
            sqlParams.Last().Value = txtZip.Text;

            sqlParams.Add(new SqlParameter("@HomePhone", SqlDbType.VarChar));
            sqlParams.Last().Value = txtHomePhone.Text;

            sqlParams.Add(new SqlParameter("@WorkPhone", SqlDbType.VarChar));
            sqlParams.Last().Value = txtWorkPhone.Text;

            sqlParams.Add(new SqlParameter("@MobilePhone", SqlDbType.VarChar));
            sqlParams.Last().Value = txtCellPhone.Text;

            sqlParams.Add(new SqlParameter("@Email", SqlDbType.VarChar));
            sqlParams.Last().Value = txtEmail.Text;

            sqlParams.Add(new SqlParameter("@HorseID", SqlDbType.Int));
            sqlParams.Last().Value = cboHorseName.SelectedValue;

            sqlParams.Add(new SqlParameter("@SchoolID", SqlDbType.VarChar));
            sqlParams.Last().Value = cboSchoolName.SelectedValue;

            sqlParams.Add(new SqlParameter("@SkillLevelID", SqlDbType.VarChar));
            sqlParams.Last().Value = cboNewRiderSkillLevel.SelectedValue;

            sqlParams.Add(new SqlParameter("@IsDependent", SqlDbType.Bit));
            sqlParams.Last().Value = isMinorCheckBox.Checked;

            sqlParams.Add(new SqlParameter("@ParentID", SqlDbType.Int));
            sqlParams.Last().Value = cboNewRiderParent.SelectedItem;

            // and so on

            Program.ExecuteStoredProc("pAddCustomer", sqlParams.ToArray<SqlParameter>());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isMinorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cboNewRiderParent.Enabled = isMinorCheckBox.Checked;
        }

        private void cboNewRiderParent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
