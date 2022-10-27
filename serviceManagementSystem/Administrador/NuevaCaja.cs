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
    public partial class NuevaCaja : Form
    {
        public NuevaCaja()
        {
            InitializeComponent();
        }

        private void NuevaCaja_Load(object sender, EventArgs e)
        {

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
    }
}
