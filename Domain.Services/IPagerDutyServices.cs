using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IPagerDutyServices
    {
        Task<IEnumerable<string>> GetAllAbilitiesAsync();
    }
}