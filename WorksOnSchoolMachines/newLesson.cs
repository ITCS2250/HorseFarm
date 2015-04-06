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
    public partial class newLesson : Form
    {
        public newLesson()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newLesson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'horseFarmDataSet1.ExperienceLevels' table. You can move, or remove it, as needed.
            this.experienceLevelsTableAdapter.Fill(this.horseFarmDataSet1.ExperienceLevels);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Dependents' table. You can move, or remove it, as needed.
            this.dependentsTableAdapter.Fill(this.horseFarmDataSet1.Dependents);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.horseFarmDataSet1.Instructors);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.Lessons' table. You can move, or remove it, as needed.
            this.lessonsTableAdapter.Fill(this.horseFarmDataSet1.Lessons);
            // TODO: This line of code loads data into the 'horseFarmDataSet1.vCustomers' table. You can move, or remove it, as needed.
            this.vCustomersTableAdapter.Fill(this.horseFarmDataSet1.vCustomers);

        }
    }
}
