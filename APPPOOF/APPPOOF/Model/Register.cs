using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class Register
    {
        public int idRegistro { get; set; }
        public int idUsuario { get; set; }
        public bool entrada { get; set; }
        public DateTime fecha_hora { get; set; }
        public int temperatura { get; set; }

        public Register() { }

        public Register( int pidRegistro,int pidUsuario, bool pentrada, DateTime pfecha_hora,int ptemperatura)
        {
            idRegistro = pidRegistro;
            idUsuario=pidUsuario;
            entrada = pentrada;
            fecha_hora = pfecha_hora;
            temperatura =ptemperatura;
        }
        
    }
}
