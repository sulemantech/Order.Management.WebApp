using Microsoft.EntityFrameworkCore;
using Order.Management.WebApp.Data;
using Order.Management.WebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Respository
{
    public class SupplierRepository:ISupplierRepository
    {

        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public SupplierRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of Suppliers
        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _appDBContext.Suppliers.ToListAsync();
        }
        #endregion

        #region Insert Supplier
        public async Task<bool> InsertSupplierAsync(Supplier supplier)
        {
            await _appDBContext.Suppliers.AddAsync(supplier);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get Supplier by Id
        public async Task<Supplier> GetSupplierAsync(int Id)
        {
            Supplier supplier = await _appDBContext.Suppliers.FirstOrDefaultAsync(c => c.Supplierid.Equals(Id));
            return supplier;
        }
        #endregion

        #region Update Supplier
        public async Task<bool> UpdateSupplierAsync(Supplier supplier)
        {
            _appDBContext.Suppliers.Update(supplier);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteSupplier
        public async Task<bool> DeleteSupplierAsync(Supplier supplier)
        {
            _appDBContext.Remove(supplier);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }

}

