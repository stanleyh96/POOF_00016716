using APPPOOF.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPPOOF.Model
{
    class RegisterDAO
    {
        public static List<Register> getLista()
        {
            string sql = "select * from product";

            DataTable dt = ConnectionDB.query(sql);

            List<Register> lista = new List<Register>();
            foreach (DataRow fila in dt.Rows)
            {
                Register r = new Register();
                r.idRegistro = Convert.ToInt32(fila[0].ToString());
                r.idUsuario = Convert.ToInt32(fila[1].ToString());
                r.entrada= Convert.ToBoolean(fila[2].ToString());
                r.fecha_hora = Convert.ToDateTime(fila[3].ToString());
                r.temperatura = Convert.ToInt32(fila[4].ToString());

                lista.Add(r);
            }

            return lista;
        }


        public static void addRegister(DateTime fecha_hora,int idUsuario, bool entrada, int temperatura)
        {
            string sFecha = fecha_hora.ToString("yyyy-MM-dd") ;

            string sql = String.Format(
                "INSERT INTO REGISTER(idUsuario, entrada, fecha_hora,temperatura)" +
                "values ({1}, {2}, {3},{4});"
                ,idUsuario,entrada,sFecha,temperatura);
            //string sql = String.Format(
            //    "insert into REGISTER (idRegistro, idUsuario,entrada,fecha_hora,temperatura)  " +
            //    "values ({0}, {1},{2},'{3}',{4});", r.idRegistro, r.idUsuario,r.entrada,r.fecha_hora,r.temperatura);

            ConnectionDB.nonQuery(sql);
        }
    }
}
