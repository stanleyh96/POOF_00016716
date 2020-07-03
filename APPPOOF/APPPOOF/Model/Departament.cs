using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class Departament
    {
        public int idDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        public Departament() { }

        public Departament(int pidDepartamento, string pNombre,string pUbicacion)
        {
            idDepartamento = pidDepartamento;
            Nombre = pNombre;
            Ubicacion = pUbicacion;

        }
    }
}
