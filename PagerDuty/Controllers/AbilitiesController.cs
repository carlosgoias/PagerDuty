using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PagerDuty.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v1/[controller]")]
    public class AbilitiesController : ControllerBase
    {
        private readonly IAbilityServices abilityServices;

        public AbilitiesController(IAbilityServices abilityServices)
        {
            this.abilityServices = abilityServices;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<string>> Get()
        {
            return await this.abilityServices
                .GetAllAsync();
        }
    }
}