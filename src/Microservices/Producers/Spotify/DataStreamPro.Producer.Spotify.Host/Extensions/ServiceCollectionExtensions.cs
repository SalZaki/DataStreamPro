using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.IO;
using System;

namespace DataStreamPro.Producer.Spotify.Host.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfigureOptions>();
            services.AddSwaggerGen(options =>
            {
                options.OperationFilter<SwaggerIOperationFilter>();
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "DataStreamPro.Producer.Spotify.WebApi.xml"));
                options.CustomSchemaIds(i => i.FullName);
            });
            return services;
        }
    }
}