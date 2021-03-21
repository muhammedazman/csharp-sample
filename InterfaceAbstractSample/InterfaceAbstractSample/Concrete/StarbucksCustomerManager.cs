using InterfaceAbstractSample.Abstracts;
using InterfaceAbstractSample.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractSample.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void save(Customer customer)
        {
            
            if(_customerCheckService.CheckIfRealPerson(customer)) {
                Console.WriteLine(customer.FirstName + " save to Starbucks");
                base.save(customer);
            }
        }
    }
}