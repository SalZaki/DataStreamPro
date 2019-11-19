using MediatR;

using DataStreamPro.Producer.Spotify.Application.Models;

namespace DataStreamPro.Producer.Spotify.Application.Queries
{
    public class GetTokenRequest : IRequest<GetTokenResponse>
    {
    }
}