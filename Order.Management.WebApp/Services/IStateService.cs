using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Data
{
    public interface IStateService
    {
        Task<List<State>> GetAllStatesAsync();
    }
}