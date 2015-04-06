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
    public partial class newRider : Form
    {
        public newRider()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
