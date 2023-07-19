using Api.ShopSpirit.Business.Model.Product;
using Api.ShopSpirit.Business.Service.Contract;
using Api.ShopSpirit.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Business.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public Task<ProductReadDTO> CreateProductAsync(ProductAddDTO productToAdd)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductReadDTO> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductReadDTO> GetProductByNameAsync(string ProductName)
        {
            throw new NotImplementedException();
        }

        public Task<ProductReadDTO> UpdateProductAsync(ProductAddDTO productToAdd)
        {
            throw new NotImplementedException();
        }
    }
}
