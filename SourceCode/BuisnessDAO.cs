using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class BuisnessDAO
    {
        public static List<Buisness> getList(){
            string sql = "select * from BUISNESS";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Buisness> lista = new List<Buisness>();
            foreach (DataRow fila in dt.Rows)
            {
                Buisness b = new Buisness();
                b.idbuisness = Convert.ToInt32(fila[0]);
                b.name = fila[1].ToString();
                b.description = fila[2].ToString();
                lista.Add(b);
            }
            return lista;
        }
    }
}