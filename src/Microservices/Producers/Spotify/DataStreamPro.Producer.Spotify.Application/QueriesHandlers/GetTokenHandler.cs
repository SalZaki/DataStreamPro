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
    public class GetTokenHandler : IRequestHandler<GetTokenRequest, GetTokenResponse>
    {
        private readonly ISpotifyService _spotifyService;
        private readonly IMapper _mapper;

        public GetTokenHandler(ISpotifyService spotifyService, IMapper mapper)
        {
            _mapper = mapper;
            _spotifyService = spotifyService;
        }

        public async Task<GetTokenResponse> Handle(GetTokenRequest request, CancellationToken cancellationToken)
        {
            var result = await _spotifyService.SpotifyWebApiClient.GetTokenAsync().ConfigureAwait(false);
            if (result == null) throw new Exception($"Couldn't get token");

            return new GetTokenResponse
            {
                Result = result
            };
        }
    }
}