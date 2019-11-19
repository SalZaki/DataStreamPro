using System;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Exceptions
{
    public class SpotifyWebApiClientException : SpotifyWebApiException
    {

        public SpotifyWebApiClientException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}