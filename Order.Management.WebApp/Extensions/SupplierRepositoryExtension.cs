using Order.Management.WebApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace Order.Management.WebApp.Extensions
{
    public static class SupplierRepositoryExtension
    {
        public static List<Supplier> Search(this List<Supplier> suppliers, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return suppliers;
            var lowerCaseSearchTerm = searchTerm.Trim().ToLower();
            return suppliers.Where(p => p.Name.ToLower().Contains(lowerCaseSearchTerm)).ToList();
        }
    }
}
