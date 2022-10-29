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
    public partial class AdminInventario : Form
    {
        public AdminInventario()
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

        private void AdminInventario_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {

                panel1.Visible = true;
                panel10.Visible = true;
                panel11.Visible = true;
                label1.Visible = true;
                label10.Visible = true;
                label11.Visible = true;

            }
            else
            {
                panel1.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                label1.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            validaciones.decimalValidation(sender, e);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.intValidate(sender, e);
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.intValidate(sender, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            validaciones.decimalValidation(sender, e);
        }
    }
}
