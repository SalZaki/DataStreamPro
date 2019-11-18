using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc.Filters;

using DataStreamPro.Producer.Spotify.WebApi.Filters.Exceptions;

namespace DataStreamPro.Producer.Spotify.WebApi.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class GlobalFiltersRegistration
    {
        public static void AddGlobalExceptionFilters(this FilterCollection filterCollection)
        {
            filterCollection.Add<SpotifyWebApiClientExceptionFilter>();
        }
    }
}