using System;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Exceptions
{
    public abstract class BaseSpotifyApiException : Exception
    {
        protected BaseSpotifyApiException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }
    }
}
