using Api.ShopSpirit.Data.Context.Contract;
using Api.ShopSpirit.Data.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.Data.Context
{
    public class ShopSpiritDBContext : DbContext, IShopSpiritContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeteoDBContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public ShopSpiritDBContext(DbContextOptions<ShopSpiritDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public DbSet<Product> Product { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }

    }
}
