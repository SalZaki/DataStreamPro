using System.Collections.Generic;
using System.Reflection;

using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataStreamPro.Producer.Spotify.WebApi.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreComponents(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services, IEnumerable<Assembly> registeredAssemblies)
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(registeredAssemblies));
            return services;
        }
    }
}