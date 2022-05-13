using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Gateway.PagerDuty;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PagerDuty.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AbilitiesController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IPagerDutyGateway pagerDutyGateway;

        public AbilitiesController(ILogger<WeatherForecastController> logger, IPagerDutyGateway pagerDutyGateway)
        {
            _logger = logger;
            this.pagerDutyGateway = pagerDutyGateway;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<string>> Get()
        {
            return await this.pagerDutyGateway
                .GetAbilitiesAsync();
        }
    }
}