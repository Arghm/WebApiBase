using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Common.Swagger
{
    public static class SwaggerConfig
    {
        /// <summary>
        /// Использование Swagger
        /// </summary>
        public static IApplicationBuilder UseSwaggerMode(this IApplicationBuilder builder, IConfiguration configuration)
        {
            builder.UseSwagger();
            builder.UseMiniProfiler();

            var progName = Assembly.GetCallingAssembly().GetName().Name;
            var projName = Assembly.GetExecutingAssembly().GetName().Name;

            builder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", progName);
                c.RoutePrefix = "swagger";
                //c.IndexStream = () => Assembly.GetExecutingAssembly().GetManifestResourceStream($"{projName}.Swagger.SwaggerIndex.html");
            });

            return builder;
        }

        /// <summary>
        /// Добавить swagger и miniProfiler в сервисы
        /// </summary>
        public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMiniProfiler(m => m.RouteBasePath = "/profiler");
            services.AddSwaggerGen();
            return services;
        }


    }
}
