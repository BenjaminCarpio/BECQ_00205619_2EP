using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class ProductDAO
    {
        public static List<Product> getList(){
            string sql = "select * from PRODUCT";

            DataTable dt = ConnectionDB.ExecuteQuery(sql);

            List<Product> lista = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product p = new Product();
                p.idproduct = Convert.ToInt32(fila[0]);
                p.idbuisness = Convert.ToInt32(fila[1]);
                p.name = fila[2].ToString();
                lista.Add(p);
            }
            return lista;
        }
        public static List<Product> getListProductsFromStore(int currentid){
                    string sql = $"SELECT p.idProduct, p.name FROM PRODUCT p WHERE idBusiness = {currentid}";
        
                    DataTable dt = ConnectionDB.ExecuteQuery(sql);
        
                    List<Product> lista = new List<Product>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        Product p = new Product();
                        p.idproduct = Convert.ToInt32(fila[0]);
                        p.idbuisness = Convert.ToInt32(fila[1]);
                        p.name = fila[2].ToString();
                        lista.Add(p);
                    }
                    return lista;
                }
        
    }
}