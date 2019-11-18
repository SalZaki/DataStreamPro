using System;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Exceptions
{
    public abstract class SpotifyApiException : Exception
    {
        protected SpotifyApiException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }
    }
}
