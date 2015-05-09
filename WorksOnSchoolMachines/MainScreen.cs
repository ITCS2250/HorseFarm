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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            Program.mainScreen = this;
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

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewHorse();
            form.Show();
        }

        private void schoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewSchool();
            form.Show();
        }

        private void vetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewVet();
            form.Show();
        }

        private void customerCampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewCustomerCamp();
            form.Show();
        }

        private void instructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewInstructor();
            form.Show();
        }

        private void lessonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new newLesson();
            form.Show();
        }

        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new NewShow();
            form.Show();
        }

        private void newCampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NewCamp();
            form.Show();
        }
    }
}
