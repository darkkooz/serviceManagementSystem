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
    public partial class ConsultaFactura : Form
    {
        public ConsultaFactura()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserIndex userIndex = new UserIndex();
            userIndex.Show();
        }
    }
}
