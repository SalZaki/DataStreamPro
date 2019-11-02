using Microsoft.AspNetCore.Mvc;

namespace DataStreamPro.Producer.Spotify.WebApi.Controllers
{
    [ApiController]
    [Produces("application/xml", "application/json")]
    public abstract class BaseController : ControllerBase
    {
    }
}
