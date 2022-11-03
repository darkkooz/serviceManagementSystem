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
    public partial class BdSelection : Form
    {
        public BdSelection()
        {
            InitializeComponent();
        }

        private void btnCQL_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void BdSelection_Load(object sender, EventArgs e)
        {

        }
    }
}
