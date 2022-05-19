using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Gateway.PagerDuty;
using Data.Gateway.PagerDuty.DataGateway;

namespace Domain.Services
{
    internal class PagerDutyServices : IPagerDutyServices
    {
        private readonly IPagerDutyGateway pagerDutyGateway;

        public PagerDutyServices(IPagerDutyGateway pagerDutyGateway)
        {
            this.pagerDutyGateway = pagerDutyGateway;
        }

        public async Task<IEnumerable<string>> GetAllAbilitiesAsync()
        {
            return await this.pagerDutyGateway.GetAbilitiesAsync();
        }

        public async Task<IEnumerable<UserData>> GetUsersAsync()
        {
            return await this.pagerDutyGateway.GetUsersAsync();
        }
    }
}