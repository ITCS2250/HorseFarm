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

        }

        private void btnNewRiderSubmit_Click(object sender, EventArgs e)
        {
            SqlParameter[] sqlParams = new SqlParameter[16];

            sqlParams[0] = new SqlParameter("@Prefix", SqlDbType.VarChar);
            sqlParams[0].Value = "Mr.";

            sqlParams[1] = new SqlParameter("@FirstName", SqlDbType.VarChar);
            sqlParams[1].Value = txtNewStudentFirstName.Text;

            sqlParams[2] = new SqlParameter("@LastName", SqlDbType.VarChar);
            sqlParams[2].Value = txtNewStudentLastName.Text;

            sqlParams[3] = new SqlParameter("@Address", SqlDbType.VarChar);
            sqlParams[3].Value = "123 Any Street";

            sqlParams[4] = new SqlParameter("@State", SqlDbType.VarChar);
            sqlParams[4].Value = "Yugoslavia";

            sqlParams[5] = new SqlParameter("@ZIP", SqlDbType.VarChar);
            sqlParams[5].Value = "48317";

            sqlParams[6] = new SqlParameter("@HomePhone", SqlDbType.VarChar);
            sqlParams[6].Value = "867-5309";

            sqlParams[7] = new SqlParameter("@WorkPhone", SqlDbType.VarChar);
            sqlParams[7].Value = "867-5309";

            sqlParams[8] = new SqlParameter("@MobilePhone", SqlDbType.VarChar);
            sqlParams[8].Value = "867-5309";

            sqlParams[9] = new SqlParameter("@Email", SqlDbType.VarChar);
            sqlParams[9].Value = "aguy@gmail.com";

            sqlParams[10] = new SqlParameter("@HorseID", SqlDbType.Int);
            sqlParams[10].Value = 1;

            sqlParams[11] = new SqlParameter("@FirstLessonDate", SqlDbType.Date);
            sqlParams[11].Value = dateTimeArrived.Value;

            sqlParams[12] = new SqlParameter("@SchoolID", SqlDbType.VarChar);
            sqlParams[12].Value = 1;

            sqlParams[13] = new SqlParameter("@SkillLevelID", SqlDbType.VarChar);
            sqlParams[13].Value = 1;

            sqlParams[14] = new SqlParameter("@IsDependent", SqlDbType.Bit);
            sqlParams[14].Value = isMinorCheckBox.Checked;

            sqlParams[15] = new SqlParameter("@ParentID", SqlDbType.Int);
            sqlParams[15].Value = parentComboBox.SelectedItem;

            // and so on

            Program.ExecuteStoredProc("pAddCustomer", sqlParams);
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
