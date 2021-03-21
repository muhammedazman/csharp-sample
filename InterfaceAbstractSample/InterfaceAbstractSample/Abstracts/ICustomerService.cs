using InterfaceAbstractSample.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractSample.Abstracts
{
    public interface ICustomerService
    {
        void save(Customer customer);
    }
}
