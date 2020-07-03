using APPPOOF.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class UserDao
    {
        public static List<User> getLista()
        {
            string sql = "select * from USUARIO ";

            DataTable dt = ConnectionDB.query(sql);


            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User u = new User();
                u.idUsuario = Convert.ToInt32(fila[0].ToString());
                u.idDepartamento = Convert.ToInt32(fila[1].ToString());
                u.contraseña = Convert.ToString(fila[2].ToString());
                u.nombre = fila[3].ToString();
                u.apellido = fila[4].ToString();
                u.dui = Convert.ToInt32(fila[5].ToString());
                u.fecha_nacimiento =Convert.ToDateTime(fila[6].ToString());
                

                lista.Add(u);
            }
            return lista;
        }
    }
}
