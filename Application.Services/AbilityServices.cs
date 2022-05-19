using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Services;

namespace Application.Services
{
    internal class AbilityServices : IAbilityServices
    {
        private readonly IPagerDutyServices pagerDutyServices;

        public AbilityServices(IPagerDutyServices pagerDutyServices)
        {
            this.pagerDutyServices = pagerDutyServices;
        }

        public async Task<IEnumerable<string>> GetAllAsync()
        {
            return await this.pagerDutyServices.GetAllAbilitiesAsync();
        }
    }
}