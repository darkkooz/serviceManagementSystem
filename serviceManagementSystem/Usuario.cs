using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serviceManagementSystem
{
    public class Usuario_
    {

        private string email { get; set; }
        private string contrasenia { get; set; }
        private string nombres { get; set; }
        private string apellidoPaterno { get; set; }
        private string apellidoMaterno { get; set; }
        private string curp { get; set; }
        private string fechaNacimiento { get; set; }
        private string fechaIngresoEmpresa { get; set; }
        private string numeroNomina { get; set; }
        private int idRolUsuario { get; set; }




        public Usuario_() { }


        public Usuario_(string email, string contrasenia, string nombres, string apellidoPaterno, string apellidoMaterno,
           string curp, string fechaNacimiento, string fechaIngresoEmpresa, string numeroNomina, int idRolUsuario)
        {


        }



    }
}
