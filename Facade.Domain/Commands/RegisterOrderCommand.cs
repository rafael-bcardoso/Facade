using System.Collections.Generic;

namespace Facade.Domain.Commands
{
    public class RegisterOrderCommand
    {
        public RegisterOrderCommand(int customerId, List<RegisterOrderItemCommand> items)
        {
            CustomerId = customerId;
            Items = items;
        }

        public int CustomerId { get; set; }
        public List<RegisterOrderItemCommand> Items { get; set; }
    }
}
