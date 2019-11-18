using System;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Exceptions
{
    public class SpotifyWebApiException : SpotifyApiException
    {
        public SpotifyWebApiException(string message, Exception innerException) :
            base(message, innerException)
        {
        }
    }
}
