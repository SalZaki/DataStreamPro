using DataStreamPro.Producer.Spotify.Domain;

namespace DataStreamPro.Producer.Spotify.Domain.Exceptions
{
    public class DomainException : BaseException
    {
        public DomainException(string message)
            : base(message, null)
        {
        }
    }
}