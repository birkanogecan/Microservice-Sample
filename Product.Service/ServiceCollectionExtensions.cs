using Microsoft.Extensions.DependencyInjection;
using Product.Service.BLL.Contract;
using Product.Service.BLL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProductService(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
