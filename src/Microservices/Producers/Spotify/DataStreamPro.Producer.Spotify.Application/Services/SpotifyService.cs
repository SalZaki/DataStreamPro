using System;
using DataStreamPro.Producer.Spotify.Application.Interfaces;

namespace DataStreamPro.Producer.Spotify.Application.Services
{
    public sealed class SpotifyService : ISpotifyService
    {
        public ISpotifyWebApiClient SpotifyWebApiClient { get; }

        public SpotifyService(ISpotifyWebApiClient spotifyApiClient)
        {
            SpotifyWebApiClient = spotifyApiClient ?? throw new ArgumentNullException(nameof(spotifyApiClient));
        }
    }
}