using ShopOnlineApi.Entities;
using ShopOnlineApi.Repositories.Contracts;

namespace ShopOnlineApi.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<IEnumerable<ProductCategory>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetItems()
        {
           
        }
    }
}
