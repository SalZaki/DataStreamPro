using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;

using DataStreamPro.Producer.Spotify.Application.Models;

namespace DataStreamPro.Producer.Spotify.Application.Interfaces
{
    public interface ISpotifyWebApiClient
    {
        JsonSerializerSettings JsonSettings { get; set; }

        Task<Token> GetTokenAsync();

        Task<IEnumerable<PlayList>> GetUserPlaylistsAsync(string id);

        Task<PlayList> GetUserPlaylistAsync(string id);
    }
}