using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using DataStreamPro.Producer.Spotify.Infrastructure.Settings;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ISpotifyWebApiSettings>(settings => configuration.GetSection(nameof(SpotifyWebApiSettings)).Bind(settings));
            return services;
        }
    }
}