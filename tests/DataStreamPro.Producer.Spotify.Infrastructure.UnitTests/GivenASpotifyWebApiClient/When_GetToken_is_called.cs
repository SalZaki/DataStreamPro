using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

using Moq;
using Xunit;
using Shouldly;
using Newtonsoft.Json;

using DataStreamPro.Producer.Spotify.Application.Interfaces;

using DataStreamPro.Producer.Spotify.Infrastructure.Http;
using DataStreamPro.Producer.Spotify.Infrastructure.Schema;
using DataStreamPro.Producer.Spotify.Infrastructure.Exceptions;
using DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.Fakes;
using DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.Helpers;

namespace DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.GivenASpotifyWebApiClient
{
    public class When_GetToken_Is_Called : BaseTest
    {
        private ISpotifyWebApiClient _sut;

        [Theory]
        [LoadTextData("authToken")]
        public async Task Then_It_Should_Return_A_Valid_Token(AuthToken authToken)
        {
            // Arrange
            var token = new StringContent(JsonConvert.SerializeObject(authToken), Encoding.UTF8, "application/json");
            var fakeHttpMessageHandler = new FakeHttpMessageHandler(token, HttpStatusCode.OK);
            MockHttpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(new HttpClient(fakeHttpMessageHandler));

            _sut = new SpotifyWebApiClient(Mapper, MockHttpClientFactory.Object, MockApiSettings.Object, MockLogger.Object);

            // Act
            var response = await _sut.GetTokenAsync().ConfigureAwait(false);

            // Aseert
            response.ShouldNotBe(null);
            response.AccessToken.ShouldBe("NgCXRK");
            response.ExpiresIn.ShouldBe(3600);
            response.RefreshToken.ShouldBe("NgAagA");
            response.TokenType.ShouldBe("Bearer");
        }

        [Theory]
        [LoadTextData("authError")]
        public async Task Then_It_Should_Throw_SpotifyWebApiClientException_When_Request_Is_Invalid(AuthError authError)
        {
            // Arrange
            var error = new StringContent(JsonConvert.SerializeObject(authError), Encoding.UTF8, "application/json");
            var fakeHttpMessageHandler = new FakeHttpMessageHandler(error, HttpStatusCode.BadRequest);
            MockHttpClientFactory.Setup(x => x.CreateClient(It.IsAny<string>())).Returns(new HttpClient(fakeHttpMessageHandler));

            _sut = new SpotifyWebApiClient(Mapper, MockHttpClientFactory.Object, MockApiSettings.Object, MockLogger.Object);

            // Act
            var ex = await Assert.ThrowsAsync<SpotifyWebApiClientException>(() => _sut.GetTokenAsync());

            // Aseert
            ex.ShouldNotBe(null);
        }
    }
}