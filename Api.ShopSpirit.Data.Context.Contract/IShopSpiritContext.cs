using Api.ShopSpirit.Data.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Data.Context.Contract
{
    public interface IShopSpiritContext
    {
        DbSet<Product> Product { get; set; }

    }
}
