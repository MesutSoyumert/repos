using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            // İş kuralları
            // Yetkisi var mı?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryID(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }
    }
}
