using Api.ShopSpirit.Data.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Data.Repository.Contract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product> GetProductByName(string product);
    }
}
