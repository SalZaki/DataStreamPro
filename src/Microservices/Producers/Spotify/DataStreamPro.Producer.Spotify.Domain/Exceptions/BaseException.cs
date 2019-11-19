using System;

namespace DataStreamPro.Producer.Spotify.Domain
{
    public abstract class BaseException : Exception
    {
        public BaseException(string message)
            : this(message, null)
        {
        }

        public BaseException(string message, Exception innerEx)
            : base(message, innerEx)
        {
        }
    }
}