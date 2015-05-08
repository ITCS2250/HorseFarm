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


        }
    }
}
