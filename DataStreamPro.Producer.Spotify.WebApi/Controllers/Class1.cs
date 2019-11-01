using System;
using System.Collections.Generic;
using System.Text;

namespace DataStreamPro.Producer.Spotify.WebApi.Controllers
{
    [ApiController]
    [Produces("application/xml", "application/json")]
    public abstract class BaseController : ControllerBase
    {
    }
}
