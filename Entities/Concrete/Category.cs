using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Eger bir class interface ya da inheritance almiyorsa
    // proje buyudukce bir sorun cikarabilir.
    // Ciplak Class Kalmasin
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

}
