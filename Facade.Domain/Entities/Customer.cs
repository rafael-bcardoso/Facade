using System;

namespace Facade.Domain.Entities
{
    public class Customer
    {
        public Customer(string email)
        {
            Id = Guid.NewGuid();
            Email = email;
        }
        public Guid Id { get; private set; }
        public string Email { get; private set; }
    }
}
