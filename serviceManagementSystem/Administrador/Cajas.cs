using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviceManagementSystem.Administrador
{
    public partial class Cajas : Form
    {
        public Cajas()
        {
            InitializeComponent();
        }


        Validaciones validaciones = new Validaciones();

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                AdminIndex adminIndex = new AdminIndex();
                adminIndex.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            label6.Visible = true;
            panel3.Visible = true;




        }

        private void Cajas_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //label6.Visible = false;
            //panel3.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label6.Visible = true;
                panel3.Visible = true;

            }
            else
            {
                label6.Visible = false;
                panel3.Visible = false;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }
    }
}
