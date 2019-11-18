using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

using AutoMapper;
using Newtonsoft.Json;

using DataStreamPro.Producer.Spotify.Application.Models;
using DataStreamPro.Producer.Spotify.Application.Interfaces;

using DataStreamPro.Producer.Spotify.Infrastructure.Schema;
using DataStreamPro.Producer.Spotify.Infrastructure.Settings;
using DataStreamPro.Producer.Spotify.Infrastructure.Exceptions;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Http
{
    public class SpotifyWebApiClient : ISpotifyWebApiClient
    {
        private readonly IMapper _mapper;
        private readonly ILogger<ISpotifyWebApiClient> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ISpotifyWebApiSettings _spotifyWebApiSettings;

        public JsonSerializerSettings JsonSettings { get; set; }

        public SpotifyWebApiClient(
            IMapper mapper,
            IHttpClientFactory httpClientFactory,
            ISpotifyWebApiSettings spotifyWebApiSettings,
            ILogger<ISpotifyWebApiClient> logger)
        {
            _logger = logger;
            _mapper = mapper;
            _spotifyWebApiSettings = spotifyWebApiSettings;
            _httpClientFactory = httpClientFactory;
        }

        private string AuthHeader => $"Basic { Convert.ToBase64String(Encoding.UTF8.GetBytes(_spotifyWebApiSettings.ClientId + ":" + _spotifyWebApiSettings.ClientSecret)) }";

        public async Task<Token> GetTokenAsync()
        {
            var args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            var content = new FormUrlEncodedContent(args);

            using (var client = _httpClientFactory.CreateClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Basic {AuthHeader}");

                try
                {
                    using (var responseMessage = await client.PostAsync(_spotifyWebApiSettings.AuthUrl, content))
                    {
                        _logger.LogInformation($"Response from {_spotifyWebApiSettings.AuthUrl}. Data about the response is {responseMessage.ToString()}");
                        responseMessage.EnsureSuccessStatusCode();
                        var response = await responseMessage.Content.ReadAsStringAsync();
                        if (response == null)
                        {
                            return null;
                        }
                        var authToken = JsonConvert.DeserializeObject<AuthToken>(response);
                        return _mapper.Map<Token>(authToken);
                    }
                }

                catch (JsonReaderException ex)
                {
                    _logger.LogError(ex, $"Error from {_spotifyWebApiSettings.AuthUrl}");
                    throw new SpotifyWebApiClientException("Spotify web api client exception has occured while getting authorisation token", ex);
                }

                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Error from {_spotifyWebApiSettings.AuthUrl}");
                    throw new SpotifyWebApiClientException("Spotify web api client exception has occured while getting authorisation token", ex);
                }
            }
        }

        public Task<PlayList> GetUserPlaylistAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayList>> GetUserPlaylistsAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}