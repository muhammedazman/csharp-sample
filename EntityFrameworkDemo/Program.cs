using EntityFrameworkDemo.Abstracts;
using EntityFrameworkDemo.Business;
using EntityFrameworkDemo.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Fraework - Bir ORM - Object relation mapping
            //NHibernate
            //Dapper

            //foreach (var product in GetAllByCategory(1))
            //{
            //    Console.WriteLine(product.ProductName + " " + product.CategoryId);
            //}
            ProductManager productManager = new ProductManager(new EfProductDal());

            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());

            /*
            productManager.Add(new Product { 
                ProductName="Masa", CategoryId=1,QuantityPerUnit="4 ayakli masa",UnitPrice=1000,UnitsInStock=10
            });
            */
            /*
            productManager.Update(new Product { 
                ProductId=78,ProductName="Masa2", CategoryId=1,QuantityPerUnit="6 ayakli masa",UnitPrice=1200,UnitsInStock=10
            });
            */
            /*
            productManager.Delete(new Product{
                ProductId=78,ProductName="Masa2", CategoryId=1,QuantityPerUnit="6 ayakli masa",UnitPrice=1200,UnitsInStock=10
            });
            */

            //List<Product> products = productManager.GetAll();

            foreach (var personel in personelManager.GetAll())
            {
                Console.WriteLine("{0} {1} {2}", personel.Id, personel.Name, personel.Surname);
            }
        }

        private static List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().ToList();
            }
        }

        private static List<Product> GetAllByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().Where(p => p.CategoryId == categoryId).ToList();
            }
        }
    }
}
