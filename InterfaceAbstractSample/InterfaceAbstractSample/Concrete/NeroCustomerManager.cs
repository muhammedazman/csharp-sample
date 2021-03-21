using InterfaceAbstractSample.Abstracts;
using InterfaceAbstractSample.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractSample.Concrete
{
    public class NeroCustomerManager:BaseCustomerManager
    {
        public override void save(Customer customer)
        {
            Console.WriteLine("Nero save to " + customer.FirstName);
            base.save(customer);
        }
    }
}
