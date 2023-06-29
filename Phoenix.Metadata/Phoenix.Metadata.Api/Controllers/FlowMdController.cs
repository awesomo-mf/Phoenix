using Microsoft.AspNetCore.Mvc;
using Phoenix.Metadata.Core.Dto.FlowMd;

namespace Phoenix.Metadata.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlowMdController : ControllerBase
    {
        private readonly ILogger<FlowMdController> _logger;

        public FlowMdController(ILogger<FlowMdController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<FlowMdInfoResponse> Get()
        {
            return new List<FlowMdInfoResponse>
            {
                new FlowMdInfoResponse
                {
                    Id = Guid.NewGuid(),
                    Alias = "someAlias"
                }
            };
        }
    }
}