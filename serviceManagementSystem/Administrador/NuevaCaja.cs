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


        Validaciones validaciones = new Validaciones();
        double montoMinimo = 0;
        double montoMaximo = 0;
        double montoInicial = 0;



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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.decimalValidation(sender, e);
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            montoMinimo = double.Parse(txtMontoMinimo.Text);
            montoMaximo = double.Parse(txtMontoMaximo.Text);
            montoInicial = double.Parse(txtMontoInicial.Text);
            if (montoInicial > montoMaximo) {
                MessageBox.Show("El monto inicial debe ser menor al monto maximo especificado");
            } else if (montoInicial < montoMinimo)
            {
                MessageBox.Show("El monto inicial debe ser mayor al monto minimo especificado");
            } 






        }
    }
}
