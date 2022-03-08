using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blogs.API.Configuration.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("v{version:apiVersion}/[controller]")]
    public abstract class BaseController<T> : ControllerBase where T : class
    {
        private readonly ILogger<T> _logger;
        protected BaseController(ILogger<T> logger)
        {
            _logger = logger;
        }

        internal ILogger<T> Logger => _logger;

    }
}
