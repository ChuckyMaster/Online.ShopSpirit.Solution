using Api.ShopSpirit.Data.Entity.Entities;
using Api.ShopSpirit.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public Task<Product> CreateElementAsync(Product element)
        {
            throw new NotImplementedException();
        }

        public Task<Product> DeleteElementAsync(Product element)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByKeyAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByName(string product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateElementAsync(Product element)
        {
            throw new NotImplementedException();
        }
    }
}
