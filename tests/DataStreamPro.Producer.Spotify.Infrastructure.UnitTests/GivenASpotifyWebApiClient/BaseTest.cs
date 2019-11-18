using System;
using System.IO;
using System.Net.Http;
using Microsoft.Extensions.Logging;

using Moq;
using AutoMapper;
using Newtonsoft.Json;

using DataStreamPro.Producer.Spotify.Application.Interfaces;

using DataStreamPro.Producer.Spotify.Infrastructure.Mappings;
using DataStreamPro.Producer.Spotify.Infrastructure.Settings;
using DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.Fakes;

namespace DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.GivenASpotifyWebApiClient
{
    public abstract class BaseTest
    {
        private IMapper _mapper;
        private Mock<ILogger<ISpotifyWebApiClient>> _mockLogger;
        private Mock<ISpotifyWebApiSettings> _mockApiSettings;
        private Mock<IHttpClientFactory> _mockHttpClientFactory;
        private static readonly string FixtureDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../fixtures/");

        public IMapper Mapper
        {
            get
            {
                if (_mapper != null) return _mapper;
                _mapper = CreateMapper();
                return _mapper;
            }
        }

        public Mock<IHttpClientFactory> MockHttpClientFactory
        {
            get
            {
                if (_mockHttpClientFactory != null) return _mockHttpClientFactory;
                _mockHttpClientFactory = GetHttpClientFactory();
                return _mockHttpClientFactory;
            }
        }

        public Mock<ILogger<ISpotifyWebApiClient>> MockLogger
        {
            get
            {
                if (_mockLogger != null) return _mockLogger;
                _mockLogger = GetLogger();
                return _mockLogger;
            }
        }

        public Mock<ISpotifyWebApiSettings> MockApiSettings
        {
            get
            {
                if (_mockApiSettings != null) return _mockApiSettings;
                _mockApiSettings = GetSpotifyWebApiSettings();
                return _mockApiSettings;
            }
        }

        private string GetFixture(string file)
        {
            return File.ReadAllText(Path.Combine(FixtureDir, file));
        }

        private Mock<IHttpClientFactory> GetHttpClientFactory()
        {
            var mockHttpClientFactory = new Mock<IHttpClientFactory>();
            return mockHttpClientFactory;
        }

        private Mock<ILogger<ISpotifyWebApiClient>> GetLogger()
        {
            var mockLogger = new Mock<ILogger<ISpotifyWebApiClient>>();
            return mockLogger;
        }

        private static T GetFixture<T>(string file)
        {
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(Path.Combine(FixtureDir, file)));
        }

        private Mock<ISpotifyWebApiSettings> GetSpotifyWebApiSettings()
        {
            var mockSpotifyWebApiSettings = new Mock<ISpotifyWebApiSettings>();
            mockSpotifyWebApiSettings.SetupGet(x => x.ClientId).Returns("64CE6D07245247939C9058BB8125D0C3");
            mockSpotifyWebApiSettings.SetupGet(x => x.ClientSecret).Returns("C96780BB7CC9409B9F121A6B767F02F5");
            mockSpotifyWebApiSettings.SetupGet(x => x.AuthUrl).Returns("http://spotify.com/");
            return mockSpotifyWebApiSettings;
        }

        private IMapper CreateMapper()
        {
            var mapper = new FakeMapper()
            {
                MappingType = typeof(TokenMapping)
            };
            return mapper.CreateMapper();
        }
    }
}