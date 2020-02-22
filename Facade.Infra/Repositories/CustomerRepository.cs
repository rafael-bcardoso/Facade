using Facade.Domain.Entities;
using Facade.Domain.Repositories;

namespace Facade.Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomerById(int customerId)
        {
            return new Customer("rafael_eng31@outlook.com");
        }
    }
}
