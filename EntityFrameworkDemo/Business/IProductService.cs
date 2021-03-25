using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Business
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
