using Microsoft.EntityFrameworkCore;
using Order.Management.WebApp.Models;
using Order.Management.WebApp.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Data
{
    public class StateService : IStateService
    {

        #region Property
        private readonly IStateRepository _stateRepository;
        #endregion

        #region Constructor
        public StateService(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }
        #endregion

        #region Get List of Suppliers
        public async Task<List<State>> GetAllStatesAsync()
        {
            return await _stateRepository.GetAllStatesAsync();
        }
        #endregion
    }

}
