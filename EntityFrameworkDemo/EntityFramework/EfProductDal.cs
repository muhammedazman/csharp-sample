using EntityFrameworkDemo.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDemo.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().ToList();
            }
        }

        public Product GetById(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(p => p.ProductId == id);
            }
        }
        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //var updatedEntity = context.Entry(entity);
                //updatedEntity.State = EntityState.Modified;

                var productUpdate = context.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productUpdate.ProductName = product.ProductName;
                productUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productUpdate.QuantityPerUnit = product.QuantityPerUnit;
                productUpdate.UnitsInStock = product.UnitsInStock;
                productUpdate.CategoryId = product.CategoryId;
                context.SaveChanges();
            }
        }
    }
}
