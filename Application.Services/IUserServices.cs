using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTO.Data.Gateway.PagerDuty.DataGateway;

namespace Application.Services
{
    public interface IUserServices
    {
        Task<IEnumerable<UserDTO>> GetUserAsync();

        Task<IEnumerable<Application.DTO.Data.Gateway.PagerDuty.DataGateway.ContactMethodDTO>> GetUserContactsMethods(string username);
    }
}