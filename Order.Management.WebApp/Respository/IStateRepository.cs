using Order.Management.WebApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Respository
{
    public interface IStateRepository
    {
        Task<List<State>> GetAllStatesAsync();
    }
}
