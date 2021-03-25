using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Abstracts
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
