using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Data
{
    public interface ISupplierService
    {
        Task<bool> DeleteSupplierAsync(Supplier supplier);
        Task<List<Supplier>> GetAllSuppliersAsync();
        Task<Supplier> GetSupplierAsync(int Id);
        Task<bool> InsertSupplierAsync(Supplier supplier);
        Task<bool> UpdateSupplierAsync(Supplier supplier);
    }
}