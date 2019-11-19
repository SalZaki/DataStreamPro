using System.Net.Http;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Http
{
    public interface IHttpClientHandlerFactory
    {
        HttpClientHandler CreateHandler();
    }
}