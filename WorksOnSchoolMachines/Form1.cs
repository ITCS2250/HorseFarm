using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseFarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClient_Click(object sender, EventArgs e)
        {
            var form = new newRider();
            form.Show();
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            var form2 = new newLesson();
            form2.Show();
        }

        private void btnHorse_Click(object sender, EventArgs e)
        {
            var form3 = new horseCare();
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'horseFarmDataSet1.vCustomers' table. You can move, or remove it, as needed.
            this.vCustomersTableAdapter.Fill(this.horseFarmDataSet1.vCustomers);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Dependents' table. You can move, or remove it, as needed.
            this.dependentsTableAdapter.Fill(this.horseFarmDataSet1.Dependents);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Horses' table. You can move, or remove it, as needed.
            this.horsesTableAdapter.Fill(this.horseFarmDataSet1.Horses);
            // TODO: This line of code loads data into the 'horseFarmDataSet.Dependents' table. You can move, or remove it, as needed.


        }
    }
}
