using Facade.Domain.Commands;
using Facade.Domain.Entities;
using Facade.Domain.Repositories;

namespace Facade.Domain.Facades
{
    public class MagazineFacade
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IProductRepository _productRepository;
        public MagazineFacade(ICustomerRepository customerRepository, IProductRepository productRepository)
        {
            _customerRepository = customerRepository;
            _productRepository = productRepository;
        }
        public void CreateOrder(RegisterOrderCommand command)
        {
            var customer = _customerRepository.GetCustomerById(command.CustomerId);

            var order = new Order(customer);

            foreach (var item in command.Items)
            {
                var product = _productRepository.GetProductById(item.ProductId);
                var orderItem = new OrderItem(product, item.QuantityOnHand);

                order.AddOrderItem(orderItem);
            }

            order.FinalizeOrder();
        }
    }
}
