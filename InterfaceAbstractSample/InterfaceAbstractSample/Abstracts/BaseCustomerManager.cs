using InterfaceAbstractSample.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractSample.Abstracts
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void save(Customer customer)
        {
            Console.WriteLine("Save to db");
        }
    }
}
