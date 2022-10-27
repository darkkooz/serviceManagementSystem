using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviceManagementSystem
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel10.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnNext01_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void btnNext02_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void btnPrev02_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel10.Visible = false;
        }

        private void btnPrev01_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel6.Visible = false;
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
