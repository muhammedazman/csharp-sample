using InterfaceAbstractSample.Abstracts;
using InterfaceAbstractSample.Adapter;
using InterfaceAbstractSample.Concrete;
using InterfaceAbstractSample.Entity;
using System;

namespace InterfaceAbstractSample
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisCheckManager());
            customerManager.save(new Customer
            {
                DateOfBirth = new DateTime(1985, 1, 6),
                FirstName = "Muhammed",
                LastName = "Azman",
                NatioanlityId = "123456"
            });
            Console.ReadLine();
        }
    }
}
