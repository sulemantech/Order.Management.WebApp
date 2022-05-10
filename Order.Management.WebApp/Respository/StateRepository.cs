using Microsoft.EntityFrameworkCore;
using Order.Management.WebApp.Data;
using Order.Management.WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Respository
{
    public class StateRepository: IStateRepository
    {

        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public StateRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of States
        public async Task<List<State>> GetAllStatesAsync()
        {
            return await _appDBContext.States.ToListAsync();
        }
        #endregion

    }

}

