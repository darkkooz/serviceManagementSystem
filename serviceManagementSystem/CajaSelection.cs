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

namespace serviceManagementSystem
{
    public partial class CajaSelection : Form
    {
        public CajaSelection()
        {
            InitializeComponent();
        }

        private void CajaSelection_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCaja1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserIndex userIndex = new UserIndex();
            userIndex.Show();
        }
    }
}
