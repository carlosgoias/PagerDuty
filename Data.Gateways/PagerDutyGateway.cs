using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Data.Gateway.PagerDuty;
using Data.Gateway.PagerDuty.DataGateway;

namespace Data.Gateways
{
    internal class PagerDutyGateway : IPagerDutyGateway
    {
        private readonly HttpClient httpClient;

        public PagerDutyGateway(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<string>> GetAbilitiesAsync()
        {
            var response = await httpClient.GetAsync("/abilities");

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            var adapt = Newtonsoft.Json.JsonConvert.DeserializeObject<AbilitiesResult>(result);

            return adapt.Abilities;
        }
    }
}