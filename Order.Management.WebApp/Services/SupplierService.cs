using Microsoft.EntityFrameworkCore;
using Order.Management.WebApp.Models;
using Order.Management.WebApp.Respository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Data
{
    public class SupplierService : ISupplierService
    {

        #region Property
        private readonly ISupplierRepository _supplierRepository;
        #endregion

        #region Constructor
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        #endregion

        #region Get List of Suppliers
        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _supplierRepository.GetAllSuppliersAsync();
        }
        #endregion

        #region Insert Supplier
        public async Task<bool> InsertSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.InsertSupplierAsync(supplier);
        }
        #endregion

        #region Get Supplier by Id
        public async Task<Supplier> GetSupplierAsync(int Id)
        {
            return await _supplierRepository.GetSupplierAsync(Id);
        }
        #endregion

        #region Update Supplier
        public async Task<bool> UpdateSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.UpdateSupplierAsync(supplier);
        }
        #endregion

        #region DeleteSupplier
        public async Task<bool> DeleteSupplierAsync(Supplier supplier)
        {
            return await _supplierRepository.DeleteSupplierAsync(supplier);
        }
        #endregion
    }

}
