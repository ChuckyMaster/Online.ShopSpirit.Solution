using Api.ShopSpirit.Business.Model.Product;
using Api.ShopSpirit.Data.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Business.Service
{
    public static class Mapper
    {
        public static ProductReadDTO TransformProductToDTO(Product product)
        {
            ProductReadDTO departementRead = new ProductReadDTO()
            {
                Id = product.Id,
                ProductName = product.Name,
                ProductDescription = product.Description,
                ProductPrice = (int)product.Price
               
            };

            return departementRead;
        }



    }
}
