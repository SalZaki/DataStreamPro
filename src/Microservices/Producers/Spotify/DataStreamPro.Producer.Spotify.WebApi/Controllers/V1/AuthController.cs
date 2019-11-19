using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using DataStreamPro.Producer.Spotify.Application.Models;

namespace DataStreamPro.Producer.Spotify.WebApi.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:ApiVersion}/[controller]")]
    [Produces("application/json")]
    public class AuthController : BaseController
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
            : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Gets token.
        /// </summary>
        /// <param name="cancellationToken">a cancellation token.</param>
        /// <returns>A token.</returns>
        [HttpGet]
        [Route("/token", Name = nameof(GetTokenAsync))]
        [ProducesResponseType(typeof(Response<Token>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTokenAsync(CancellationToken cancellationToken = default)
        {

        }
    }
}