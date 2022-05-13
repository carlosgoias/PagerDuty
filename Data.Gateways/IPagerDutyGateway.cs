using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Gateway.PagerDuty
{
    public interface IPagerDutyGateway
    {
        Task<IEnumerable<string>> GetAbilitiesAsync();
    }
}