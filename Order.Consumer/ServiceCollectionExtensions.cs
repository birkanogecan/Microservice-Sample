using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Consumer
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddOrderConsumer(this IServiceCollection services)
        {
            services.AddCap(options =>
            {
                options.UseMySql("Server=localhost;Port=3306;Database=CapDb;Uid=root;Pwd=my-secret-pw;");

                options.UseRabbitMQ(options =>
                {
                    options.ConnectionFactoryOptions = options =>
                    {
                        options.Ssl.Enabled = false;
                        options.HostName = "localhost";
                        options.UserName = "guest";
                        options.Password = "guest";
                        options.Port = 5672;
                    };
                });

                options.FailedRetryCount = 10;
            });
            return services;
        }
    }
}
