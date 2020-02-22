using Facade.Domain.Entities;

namespace Facade.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int customerId);
    }
}
