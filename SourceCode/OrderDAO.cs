using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class OrderDAO
    {
        public static List<Order> getList(){
            string sql = $"select * from ORDER";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Order> lista = new List<Order>();
            foreach (DataRow fila in dt.Rows)
            {
                Order o = new Order();
                o.idorder = Convert.ToInt32(fila[0]);
                o.idadress = Convert.ToInt32(fila[1]);
                o.fecha = Convert.ToDateTime(fila[2]);
                o.idadress = Convert.ToInt32(fila[3]);
                lista.Add(o);
            }
            return lista;
        }
    }
}