using Facade.Domain.Entities;

namespace Facade.Domain.Repositories
{
    public interface IProductRepository
    {
        Product GetProductById(int productId);
    }
}
