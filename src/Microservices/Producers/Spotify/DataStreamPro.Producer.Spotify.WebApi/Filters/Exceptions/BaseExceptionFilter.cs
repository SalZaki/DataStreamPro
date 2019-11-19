using DataStreamPro.Producer.Spotify.Infrastructure.Settings;

namespace DataStreamPro.Producer.Spotify.WebApi.Filters.Exceptions
{
    public abstract class BaseExceptionFilter
    {
        public string ErrorTitle { get; }

        public ISpotifyWebApiSettings SpotifyWebApiSettings { get; }

        public BaseExceptionFilter(ISpotifyWebApiSettings spotifyWebApiSettings, string errorTitle)
        {
            SpotifyWebApiSettings = spotifyWebApiSettings;
            ErrorTitle = errorTitle;
        }
    }
}