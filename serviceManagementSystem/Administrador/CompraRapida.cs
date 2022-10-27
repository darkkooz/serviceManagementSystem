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
    }
}
