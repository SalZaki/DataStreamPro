using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using AutoMapper;

using DataStreamPro.Producer.Spotify.Application.Interfaces;
using DataStreamPro.Producer.Spotify.Application.Models;
using DataStreamPro.Producer.Spotify.Application.Queries;

namespace DataStreamPro.Producer.Spotify.Application.UseCase
{
    public class GetPlaylistHandler : IRequestHandler<GetPlaylistRequest, GetPlaylistsResponse>
    {
        private readonly ISpotifyService _spotifyService;
        private readonly IMapper _mapper;

        public GetPlaylistHandler(ISpotifyService spotifyService, IMapper mapper)
        {
            _spotifyService = spotifyService;
            _mapper = mapper;
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