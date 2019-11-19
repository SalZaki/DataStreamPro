using System;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Exceptions
{
    public class SpotifyWebApiException : BaseSpotifyApiException
    {
        public SpotifyWebApiException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}