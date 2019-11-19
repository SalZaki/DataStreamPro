using DataStreamPro.Producer.Spotify.Application.Models;
using MediatR;

namespace DataStreamPro.Producer.Spotify.Application.Queries
{
    public class GetPlaylistRequest : IRequest<GetPlaylistsResponse>
    {
        public string Id { get; set; }
    }
}