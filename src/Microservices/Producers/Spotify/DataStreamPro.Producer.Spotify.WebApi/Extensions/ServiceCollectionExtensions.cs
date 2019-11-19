using AutoMapper;

using System.Reflection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using DataStreamPro.Common.Utils.Extensions;
using DataStreamPro.Producer.Spotify.Infrastructure.Http;
using DataStreamPro.Producer.Spotify.Application.Interfaces;

namespace DataStreamPro.Producer.Spotify.WebApi
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreComponents(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ISpotifyWebApiClient, SpotifyWebApiClient>(); 
            return services;
        }

        public static IServiceCollection AddAutoMapperByConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(configuration.LoadFullAssemblies());
            });

            return services;
        }

        public static IServiceCollection AddAutoMapperByAssembly(this IServiceCollection services, Assembly registeredAssembly)
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(registeredAssembly);
            });

            return services;
        }
    }
}