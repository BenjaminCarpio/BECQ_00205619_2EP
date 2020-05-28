using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class UserDAO
    {
       
        public static List<User> getList(){
            string sql = "select * from APPUSER";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User u = new User();
                u.iduser = Convert.ToInt32(fila[0]);
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.usertype = Convert.ToBoolean(fila[4]);
                lista.Add(u);
            }
            return lista;
        }
    }
}