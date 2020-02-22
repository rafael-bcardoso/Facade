using Facade.Domain.Commands;
using Facade.Domain.Facades;
using Facade.Infra.Repositories;
using System.Collections.Generic;

namespace Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var magazine = new MagazineFacade(new CustomerRepository(), new ProductRepository());

            var items = new List<RegisterOrderItemCommand>();

            items.Add(new RegisterOrderItemCommand(1, 10));
            items.Add(new RegisterOrderItemCommand(2, 10));
            items.Add(new RegisterOrderItemCommand(3, 10));
            items.Add(new RegisterOrderItemCommand(4, 10));
            items.Add(new RegisterOrderItemCommand(5, 10));

            var command = new RegisterOrderCommand(10, items);
            magazine.CreateOrder(command);
        }
    }
}