using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTO.Data.Gateway.PagerDuty.DataGateway;
using Domain.Services;

namespace Application.Services
{
    internal class UserServices : IUserServices
    {
        private readonly IDictionary<string, IEnumerable<ContactMethodDTO>> contacts;
        private readonly IPagerDutyServices pagerDutyServices;

        public UserServices(IPagerDutyServices pagerDutyServices)
        {
            this.pagerDutyServices = pagerDutyServices;
            this.contacts = new Dictionary<string, IEnumerable<ContactMethodDTO>>();
        }

        public async Task<IEnumerable<UserDTO>> GetUserAsync()
        {
            var result = await this.pagerDutyServices.GetUsersAsync();

            var resultAdapted = result.Select(d =>
            {
                var contact_methods = d.contact_methods.Select(m => new ContactMethodDTO
                {
                    type = m.type,
                    html_url = m.html_url,
                    self = m.self,
                    summary = m.summary,
                    id = m.id,
                });

                this.contacts.Add(d.name, contact_methods);

                return new UserDTO
                {
                    name = d.name
                };
            }
            );

            return resultAdapted;
        }

        public IEnumerable<ContactMethodDTO> GetUserContactsMethods(string username)
        {
            return this.contacts[username];
        }
    }
}