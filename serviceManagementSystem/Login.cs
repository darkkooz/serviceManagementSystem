using serviceManagementSystem.Administrador;
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
    public partial class Login : Form
    {


        string adminUser = "salashiram", user = "salashiram000";
        string adminPassword = "salashiram310100", userPassword = "salashiram310100";



        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            panel4.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {




            if (txtUsername.Text == user && txtPassword.Text == userPassword) 
            {
                this.Hide();
                CajaSelection cajaSelection = new CajaSelection();
                cajaSelection.Show();

            } else  if (txtUsername.Text == adminUser && txtPassword.Text == adminPassword) {

                this.Hide();
                AdminIndex adminLog = new AdminIndex();
                adminLog.Show();

            }
            else
            {
                MessageBox.Show("Las credenciales no coinciden");
            }
 





        }
    }
}
