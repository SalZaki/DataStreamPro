namespace DataStreamPro.Producer.Spotify.Common
{
    public class ErrorCode
    {
        public enum Authentication : int
        {
            AccessDenied = 1000,
            InvalidTokenRequest = 1001,
            InvalidRefreshToken = 1002,
            InvalidToken = 1003
        }
    }
}