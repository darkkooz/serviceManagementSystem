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
    public partial class ConsultaRapida : Form
    {
        public ConsultaRapida()
        {
            InitializeComponent();
        }


        Validaciones validaciones = new Validaciones();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //UserIndex userIndex = new UserIndex();
            //userIndex.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.intValidate(sender, e);
        }
    }
}
