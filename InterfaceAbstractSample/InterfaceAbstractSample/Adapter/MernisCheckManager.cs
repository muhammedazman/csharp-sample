using InterfaceAbstractSample.Concrete;
using InterfaceAbstractSample.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractSample.Adapter
{
    public class MernisCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if (customer.FirstName == "Muhammed" && customer.LastName=="Azman" &&
                customer.DateOfBirth == new DateTime(1985, 1, 6) && customer.NatioanlityId=="123456")
            {
                return true;
            }
            else
            {
                throw new Exception("This is not real Person");
            } 
        }
    }
}
