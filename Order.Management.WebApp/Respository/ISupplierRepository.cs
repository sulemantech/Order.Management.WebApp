using Order.Management.WebApp.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Respository
{
    public interface ISupplierRepository
    {
        Task<bool> DeleteSupplierAsync(Supplier supplier);
        Task<List<Supplier>> GetAllSuppliersAsync();
        Task<Supplier> GetSupplierAsync(int Id);
        Task<bool> InsertSupplierAsync(Supplier supplier);
        Task<bool> UpdateSupplierAsync(Supplier supplier);

    }
}
