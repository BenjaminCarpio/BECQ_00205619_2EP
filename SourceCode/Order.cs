using System;

namespace SourceCode
{
    public class Order
    {
        public int idorder { get; set; }
        public DateTime fecha { get; set; }
        public int idproduct { get; set; }
        public int idadress { get; set; }

        public Order()
        {
            idorder = 0;
            fecha = DateTime.Now;
            idproduct = 0;
            idadress = 0;
        }
    }
}