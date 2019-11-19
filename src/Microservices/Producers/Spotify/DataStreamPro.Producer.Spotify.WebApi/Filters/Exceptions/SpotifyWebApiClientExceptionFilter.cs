using Microsoft.AspNetCore.Mvc.Filters;

using DataStreamPro.Producer.Spotify.Infrastructure.Settings;
using DataStreamPro.Producer.Spotify.Infrastructure.Exceptions;

namespace DataStreamPro.Producer.Spotify.WebApi.Filters.Exceptions
{
    public sealed class SpotifyWebApiClientExceptionFilter : BaseExceptionFilter, IExceptionFilter
    {
        public SpotifyWebApiClientExceptionFilter(ISpotifyWebApiSettings spotifyWebApiSettings) :
            base(spotifyWebApiSettings, "Spotify web api client exception occured")
        { }

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is SpotifyWebApiClientException)
            {
                //var controller = context.RouteData.Values["controller"].ToString().ToLowerInvariant();
                //var version = context.RouteData.Values["version"].ToString().ToLowerInvariant();
                //var documentationUrl = SpotifyWebApiSettings.ApiDocumentationUrl.Replace("{VERSION}", version) + controller;
                //var errorType = Error.Customer.InvalidCustomerId.ToString();
                //var errorMessage = $"Customer not found exception has occured, bacause invalid customer id was passed.";
                //context.Result = new ErrorResult(ErrorTitle, errorMessage, errorType, documentationUrl);
                //context.ExceptionHandled = true;
            }
        }
    }
}