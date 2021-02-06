using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void add(Product product);
        void update(Product product);
        void delete(Product product);
        List<Product> GetAllByCategory(int categoryID);

    }
}
