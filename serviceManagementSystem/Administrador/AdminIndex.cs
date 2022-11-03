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
    public partial class AdminIndex : Form
    {

        public AdminIndex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cajas caja = new Cajas();
            caja.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportesProducto reportesProducto = new ReportesProducto();
            reportesProducto.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteCajero reporteCajero = new ReporteCajero();
            reporteCajero.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInventario adminInventario = new AdminInventario();
            adminInventario.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarProducto editarProducto = new EditarProducto();
            editarProducto.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistorialDeCambios historialDeCambios = new HistorialDeCambios();
            historialDeCambios.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDevoluciones registroDevoluciones = new RegistroDevoluciones();
            registroDevoluciones.Show();
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

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Cajas caja = new Cajas();
            caja.Show();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NuevaCaja nuevaCaja = new NuevaCaja();
            nuevaCaja.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminInventario adminInventario = new AdminInventario();
            adminInventario.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarProducto editarProducto = new EditarProducto();
            editarProducto.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Departamento departamento = new Departamento();
            departamento.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarDepartamento editarDepartamento = new EditarDepartamento();
            editarDepartamento.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteCajero reporteCajero = new ReporteCajero();
            reporteCajero.Show();
        }
    }
}
