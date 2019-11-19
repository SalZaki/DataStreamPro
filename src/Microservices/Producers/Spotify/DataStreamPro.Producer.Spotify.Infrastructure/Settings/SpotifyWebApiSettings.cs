using System.Diagnostics.CodeAnalysis;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Settings
{
    [ExcludeFromCodeCoverage]
    public class SpotifyWebApiSettings : ISpotifyWebApiSettings
    {
        public string AuthUrl { get; set; }

        public string BaseUrl { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string ApiDocumentationUrl { get; set; }
    }
}