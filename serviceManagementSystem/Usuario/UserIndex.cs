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

namespace serviceManagementSystem.Usuario
{
    public partial class UserIndex : Form
    {
        public UserIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaRapida consultaRapida = new ConsultaRapida();
            consultaRapida.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaFactura consultaFactura = new ConsultaFactura();
            consultaFactura.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompraRapida compraRapida = new CompraRapida();
            compraRapida.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CompraRapida compraRapida = new CompraRapida();
            compraRapida.Show();
        }
    }
}
