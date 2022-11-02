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
    public partial class CompraRapida : Form
    {
        public CompraRapida()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Se esta generando su Factura ...","Compra exitosa");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                UserIndex userIndex = new UserIndex();
                userIndex.Show();
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                panel4.Visible = true;
                panel5.Visible = false;
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true && radioButton1.Checked == false)
            {
                panel4.Visible = false;
                panel5.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            numericUpDown1.Value = 0;
            textBox3.Clear();
            textBox4.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            textBox3.Clear();
            textBox4.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
