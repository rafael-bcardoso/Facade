using System;
using System.Collections.Generic;

namespace Facade.Domain.Entities
{
    public class Order
    {
        public Order(Customer customer)
        {
            Number = Guid.NewGuid();
            Items = new List<OrderItem>();
            Customer = customer;
        }

        public Guid Number { get; private set; }
        public IList<OrderItem> Items { get; private set; }
        public Customer Customer { get; private set; }

        public void AddOrderItem(OrderItem item)
        {
            this.Items.Add(item);
        }

        public void FinalizeOrder()
        {
            Console.WriteLine("Venda finalizada com sucesso");
        }
    }
}
