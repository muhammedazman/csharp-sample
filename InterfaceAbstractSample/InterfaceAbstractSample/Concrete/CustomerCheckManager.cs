using InterfaceAbstractSample.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractSample.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //not control
            return true;
        }
    }
}
