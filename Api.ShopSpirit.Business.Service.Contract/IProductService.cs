using Api.ShopSpirit.Business.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Business.Service.Contract
{
    public interface IProductService
    {


        Task<ProductReadDTO> CreateProductAsync(ProductAddDTO productToAdd);
        Task<ProductReadDTO> UpdateProductAsync(ProductAddDTO productToAdd);

        Task DeleteProductAsync(int id);
        Task<ProductReadDTO> GetProductAsync(int id);
        Task<ProductReadDTO> GetProductByNameAsync(string ProductName);


    }
}
