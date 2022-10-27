using serviceManagementSystem.Usuario;
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
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            button7.BringToFront();
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = true;
            panel10.Enabled = true;
            panel11.Enabled = true;
            panel12.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminIndex adminIndex = new AdminIndex();
            adminIndex.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                panel10.Visible = true;
                panel11.Visible = true;
                panel12.Visible = true;
            }
            else
            {
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false; 
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {

            ConsultaRapida consultaRapida = new ConsultaRapida();
            consultaRapida.ShowDialog();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.BringToFront();
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            panel7.Enabled = false;
            panel8.Enabled = false;
            panel9.Enabled = false;
            panel10.Enabled = false;
            panel11.Enabled = false;
            panel12.Enabled = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
