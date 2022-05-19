using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IAbilityServices
    {
        Task<IEnumerable<string>> GetAllAsync();
    }
}