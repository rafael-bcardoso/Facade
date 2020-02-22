using Facade.Domain.Entities;
using Facade.Domain.Repositories;

namespace Facade.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductById(int productId)
        {
            return new Product("mouse", 1000);
        }
    }
}
