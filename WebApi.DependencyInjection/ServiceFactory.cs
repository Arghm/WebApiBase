using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WebApi.Common;
using WebApi.Core;

namespace WebApi.DependencyInjection
{
    public static class ServiceFactory
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Конфиги
            services.AddSingleton<DataBaseConfig>();

            //Сервисы
            services.AddSingleton<IClientService, ClientService>();
            services.AddSingleton<IClientRepositoryService, ClientRepositoryService>();

            //Конфигурация ORM
            services.AddSingleton<ConnectionFactory>();

            return services;
        }
    }
}
