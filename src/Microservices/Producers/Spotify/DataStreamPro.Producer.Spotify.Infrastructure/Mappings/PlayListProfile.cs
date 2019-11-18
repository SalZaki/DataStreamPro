//using System;
//using AutoMapper;

//using DataStreamPro.Producer.Spotify.Application.Models;

//namespace DataStreamPro.Producer.Spotify.Infrastructure.Mappings
//{
//    public sealed class PlayListProfile : Profile
//    {

//        public PlayListProfile()
//        {
//            CreateMap<SimplePlaylist, PlayList>()
//                .ForMember(x => x.Id, conf => conf.MapFrom(cg => new Guid(cg.Id)))
//                .ForMember(x => x.Href, conf => conf.MapFrom(cg => cg.Href))
//                .ForMember(x => x.Images, conf => conf.MapFrom(cg => cg.Images));
//        }
//    }
//}