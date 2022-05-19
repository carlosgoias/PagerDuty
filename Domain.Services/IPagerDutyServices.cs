using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Gateway.PagerDuty.DataGateway;

namespace Domain.Services
{
    public interface IPagerDutyServices
    {
        Task<IEnumerable<string>> GetAllAbilitiesAsync();

        Task<IEnumerable<UserData>> GetUsersAsync();
    }
}