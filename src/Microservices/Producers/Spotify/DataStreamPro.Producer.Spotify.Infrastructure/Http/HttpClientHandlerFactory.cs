using System.Net.Http;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Http
{
    public class HttpClientHandlerFactory : IHttpClientHandlerFactory
    {
        public HttpClientHandler CreateHandler()
        {
            return new HttpClientHandler();
        }
    }
}
