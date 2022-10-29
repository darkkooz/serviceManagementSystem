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
    public partial class EditarDepartamento : Form
    {
        public EditarDepartamento()
        {
            InitializeComponent();
        }

        private void EditarDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminIndex adminIndex = new AdminIndex();
            adminIndex.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) 
            {
                panel3.Enabled = true;
                panel4.Enabled = true;
                panel5.Enabled = true;
                panel7.Enabled = true;
            }
            else
            {
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel7.Enabled = false;
            }
 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button7.BringToFront();
            panel2.Enabled = true;
            panel6.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button5.BringToFront();
            panel2.Enabled = false;
            panel6.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConsultaDepartamentos consultaDepartamentos = new ConsultaDepartamentos();
            consultaDepartamentos.ShowDialog();
        }
    }
}
