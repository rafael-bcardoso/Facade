namespace Facade.Domain.Entities
{
    public class OrderItem
    {
        public OrderItem(Product product, decimal quantityOnHand)
        {
            Product = product;
            QuantityOnHand = quantityOnHand;
        }

        public Product Product { get; private set; }
        public decimal QuantityOnHand { get; private set; }
    }
}
