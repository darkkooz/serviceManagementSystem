using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serviceManagementSystem
{
    public class EnlaceDataBase
    {

        


        //Cadena de Conexion
        string cadena = "data source = DESKTOP-S34RQIR; initial catalog = Pruebas; user id = sa; password = 123456";
        
        public SqlConnection databaseConection = new SqlConnection();

        //Constructor
        public EnlaceDataBase()
        {
            databaseConection.ConnectionString = cadena;
 
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            try
            {
                databaseConection.Open();
                MessageBox.Show("conexion correcta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD ", ex.Message);
                MessageBox.Show("Error");
            }
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            databaseConection.Close();
        }


    }
}
