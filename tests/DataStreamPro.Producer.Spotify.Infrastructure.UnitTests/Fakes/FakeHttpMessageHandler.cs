using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.Fakes
{
    internal class FakeHttpMessageHandler : DelegatingHandler
    {
        private readonly string _responseContent;
        private readonly HttpContent _httpContent;
        private readonly HttpStatusCode _statusCode;

        public FakeHttpMessageHandler(string responseContent, HttpStatusCode statusCode)
        {
            _responseContent = responseContent;
            _statusCode = statusCode;
        }

        public FakeHttpMessageHandler(HttpContent httpContent, HttpStatusCode statusCode)
        {
            _httpContent = httpContent;
            _statusCode = statusCode;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return await Task.FromResult(new HttpResponseMessage
            {
                StatusCode = _statusCode,
                Content = _httpContent ?? new StringContent(_responseContent)
            });
        }
    }
}