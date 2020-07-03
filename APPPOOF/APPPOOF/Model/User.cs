using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class User
    {
        public int idUsuario { get; set; }
        public int idDepartamento { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dui { get; set; }
        public DateTime fecha_nacimiento  { get; set; }

        public User() { }

        public User(int pidUsuario, int pidDepartamento, string pcontraseña,string pnombre,
                   string papellido,int pdui, DateTime pfecha_nacimiento)
           
        {
            idUsuario = pidUsuario;
            idDepartamento = pidDepartamento;
            contraseña = pcontraseña;
            nombre = pnombre;
            apellido = papellido;
            dui = pdui;
            fecha_nacimiento = pfecha_nacimiento;
        }
    }
}
