using Microsoft.Extensions.DependencyInjection;
using Order.Service.BLL.Contract;
using Order.Service.BLL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Service
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOrderService(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            return services;
        }
    }
}
