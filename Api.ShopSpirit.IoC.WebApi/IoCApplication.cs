using Api.ShopSpirit.Business.Service;
using Api.ShopSpirit.Business.Service.Contract;
using Api.ShopSpirit.Data.Repository;
using Api.ShopSpirit.Data.Repository.Contract;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Api.ShopSpirit.IoC.WebApi
{
    public static class IoCApplication
    {
        /// <summary>
        /// Configuration de l'injection des repository du Web API RestFul
        /// </summary>
        /// <param name="services"></param>
        /// 
        public static IServiceCollection ConfigureInjectionDependencyRepository(this IServiceCollection services)
        {
            // Injections des Dépendances
            // - Repositories

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }


        /// <summary>
        /// Configure l'injection des services
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection ConfigureInjectionDependencyService(this IServiceCollection services)
        {
            // Injections des Dépendances
            // - Service
            services.AddScoped<IProductService, ProductService>();


            return services;
        }

        /// <summary>
        /// Configuration de la connexion de la base de données
        /// </summary>
        /// <param name="services"></param>
        public static IServiceCollection ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString('BddConnection'); ;

            services.AddDbContext<IProductContext>

            return services;

        }



    }
}
