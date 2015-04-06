using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorksOnSchoolMachines
{
    public partial class horseCare : Form
    {
        public horseCare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void horseCare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'horseFarmDataSet1.HorseCare' table. You can move, or remove it, as needed.
            this.horseCareTableAdapter.Fill(this.horseFarmDataSet1.HorseCare);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Vets' table. You can move, or remove it, as needed.
            this.vetsTableAdapter.Fill(this.horseFarmDataSet1.Vets);

        }
    }
}
