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
    public class UsersController : ControllerBase
    {
        private readonly IUserServices userServices;

        public UsersController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Application.DTO.Data.Gateway.PagerDuty.DataGateway.UserDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IEnumerable<Application.DTO.Data.Gateway.PagerDuty.DataGateway.UserDTO>> Get()
        {
            return await this.userServices
                .GetUserAsync();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Application.DTO.Data.Gateway.PagerDuty.DataGateway.ContactMethodDTO>), StatusCodes.Status200OK)]
        public async Task<IEnumerable<Application.DTO.Data.Gateway.PagerDuty.DataGateway.ContactMethodDTO>> GetUserContatcs([FromRoute] string username)
        {
            return await this.userServices
                .GetUserContactsMethods(username);
        }
    }
}