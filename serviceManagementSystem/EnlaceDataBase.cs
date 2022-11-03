using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceManagementSystem
{
    public class EnlaceDataBase
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();


        private static void conectar()
        {
            //string cnn = ConfigurationManager.AppSettings["desarrollo1"];
            //string cnn = ConfigurationManager.ConnectionStrings["Grupo01"].ToString();
            //_conexion = new SqlConnection(cnn);
            //_conexion.Open();
        }




    }
}
