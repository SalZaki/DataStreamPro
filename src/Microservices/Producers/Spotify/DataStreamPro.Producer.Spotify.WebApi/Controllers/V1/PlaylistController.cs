using AutoMapper;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace DataStreamPro.Producer.Spotify.WebApi.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [Produces("application/xml", "application/json")]
    public class PlaylistController : BaseController
    {
        private readonly IMapper _mapper;

        public PlaylistController(IMediator mediator)
            : base(mediator)
        {

        }
    }
}