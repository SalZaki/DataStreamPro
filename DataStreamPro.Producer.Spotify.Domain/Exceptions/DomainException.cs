using DataStreamPro.Producer.Spotify.Domain;

namespace DataSubject.Domain.Exceptions
{
    public class DomainException : BaseException
    {
        public DomainException(string message)
            : base(message, null)
        {
        }
    }
}