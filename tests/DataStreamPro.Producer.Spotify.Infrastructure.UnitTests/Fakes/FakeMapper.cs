using System;
using System.Reflection;

using AutoMapper;

namespace DataStreamPro.Producer.Spotify.Infrastructure.UnitTests.Fakes
{
    internal sealed class FakeMapper
    {
        public Type MappingType { get; set; }

        public IMapper CreateMapper()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(MappingType?.GetTypeInfo().Assembly);
            });

            return mapperConfig.CreateMapper();
        }
    }
}