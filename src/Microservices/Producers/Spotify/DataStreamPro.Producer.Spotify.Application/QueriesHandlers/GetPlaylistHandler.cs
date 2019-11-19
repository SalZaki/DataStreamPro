using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using AutoMapper;

using DataStreamPro.Producer.Spotify.Application.Models;
using DataStreamPro.Producer.Spotify.Application.Queries;
using DataStreamPro.Producer.Spotify.Application.Interfaces;

namespace DataStreamPro.Producer.Spotify.Application.QueriesHandlers
{
    public class GetPlaylistHandler : IRequestHandler<GetPlaylistRequest, GetPlaylistsResponse>
    {
        private readonly IMapper _mapper;
        private readonly ISpotifyService _spotifyService;

        public GetPlaylistHandler(ISpotifyService spotifyService, IMapper mapper)
        {
            _mapper = mapper;
            _spotifyService = spotifyService;
        }

        public async Task<GetPlaylistsResponse> Handle(GetPlaylistRequest request, CancellationToken cancellationToken)
        {
            var result = await _spotifyService.SpotifyWebApiClient.GetUserPlaylistsAsync(request.Id).ConfigureAwait(false);
            if (result == null) throw new Exception($"Couldn't find playlists:{request.Id}");

            return new GetPlaylistsResponse
            {
                //Result = result.ToDto()
            };
        }
    }
}