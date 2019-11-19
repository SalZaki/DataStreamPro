using AutoMapper;

using DataStreamPro.Producer.Spotify.Application.Models;
using DataStreamPro.Producer.Spotify.Infrastructure.Schema;

namespace DataStreamPro.Producer.Spotify.Infrastructure.Mappings
{
    public class TokenMapping : Profile
    {
        public TokenMapping()
        {
            CreateMap<Token, AuthToken>().ReverseMap();
        }
    }
}