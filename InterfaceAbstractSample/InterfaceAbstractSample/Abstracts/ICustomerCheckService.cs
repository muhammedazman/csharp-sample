using InterfaceAbstractSample.Entity;

namespace InterfaceAbstractSample.Concrete
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}