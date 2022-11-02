using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviceManagementSystem
{
    class Validaciones
    {

        public Validaciones()
        {

        }


        public void intValidate(object sender, KeyPressEventArgs e)
        {
            // solo numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        public void decimalValidation(object sender, KeyPressEventArgs e)
        {
            // solo numeros enteros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        public void textValidationWithSpaces(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Space)
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }
        public void textValidationNonSpaces(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back)) 
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

            }
        }
        public void nonSpaces(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == Convert.ToChar(Keys.Space);
        }

        public void curpValidation(object sender, KeyPressEventArgs e)
        {

            e.Handled = e.KeyChar == Convert.ToChar(Keys.Space);


        }



    }
}
