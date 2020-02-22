namespace Facade.Domain.Commands
{
    public class RegisterOrderItemCommand
    {
        public RegisterOrderItemCommand(int productId, int quantityOnHand)
        {
            ProductId = productId;
            QuantityOnHand = quantityOnHand;
        }

        public int ProductId { get; set; }
        public int QuantityOnHand { get; set; }
    }
}
