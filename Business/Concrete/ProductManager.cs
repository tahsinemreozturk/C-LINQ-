using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProdcutDal _productDal;

        public ProductManager(IProdcutDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //is kodlari
            return _productDal.GetAll();    
        }
    }
}
