using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Gateway.PagerDuty.DataGateway;

namespace Data.Gateway.PagerDuty
{
    public interface IPagerDutyGateway
    {
        Task<IEnumerable<string>> GetAbilitiesAsync();

        Task<IEnumerable<UserData>> GetUsersAsync();
    }
}