using APPPOOF.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class DepartamentDAO
    {
        public static List<Departament> getLista()
        {
            string sql = "select * from DEPARTAMENTO ";

            DataTable dt = ConnectionDB.query(sql);


            List<Departament> lista = new List<Departament>();
            foreach (DataRow fila in dt.Rows)
            {
                Departament d = new Departament();
                d.idDepartamento = Convert.ToInt32(fila[0].ToString());
                d.Nombre = fila[1].ToString();
                d.Ubicacion =fila[2].ToString();
                


                lista.Add(d);
            }
            return lista;
        }
    }
}
