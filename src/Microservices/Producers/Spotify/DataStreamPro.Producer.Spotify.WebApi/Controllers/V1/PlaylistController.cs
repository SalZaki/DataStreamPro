using Microsoft.AspNetCore.Mvc;

using MediatR;

using DataStreamPro.Producer.Spotify.WebApi.Controllers;

namespace DataStreamPro.Producer.Spotify.WebApi
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [Produces("application/xml", "application/json")]
    public class PlaylistController : BaseController
    {
        public PlaylistController(IMediator mediator)
            : base(mediator)
        {

        }
    }
}