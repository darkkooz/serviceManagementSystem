using serviceManagementSystem.Administrador;
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
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                AdminIndex adminIndex = new AdminIndex();
                adminIndex.Show();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                label1.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                panel1.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;

            }
            else
            {
                label1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                panel1.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
