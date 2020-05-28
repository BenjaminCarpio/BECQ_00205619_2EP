using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class AdressDAO
    {
        public static List<Adress> getList(){
            string sql = "select * from ADDRESS";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Adress> lista = new List<Adress>();
            foreach (DataRow fila in dt.Rows)
            {
                Adress a = new Adress();
                a.idadress = Convert.ToInt32(fila[0]);
                a.iduser = Convert.ToInt32(fila[1]);
                a.adress = fila[2].ToString();
                lista.Add(a);
            }
            return lista;
        }
        public static List<Adress> getListAdressUser(int currentid){
            string sql = $"SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {currentid}";
        
            DataTable dt = ConnectionDB.ExecuteQuery(sql);
        
            List<Adress> lista = new List<Adress>();
            foreach (DataRow fila in dt.Rows)
            {
                Adress a = new Adress();
                a.idadress = Convert.ToInt32(fila[0]);
                a.iduser = Convert.ToInt32(fila[1]);
                a.adress = fila[2].ToString();
                lista.Add(a);
            }
            return lista;
        }
    } 
}