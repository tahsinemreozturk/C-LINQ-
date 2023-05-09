using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product:IEntity //public yapinca bu class a diger katmanlar da erisebilir.
                         // internal yapinca sadece kendi icerisinde kullanilir   
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public  string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
