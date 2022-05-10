using Order.Management.WebApp.Data;
using System.Collections.Generic;

namespace Order.Management.WebApp.Models
{
    public class SeedSupplierTable
    {
        public void Seed(AppDBContext context)
        {
            IList<Supplier> defaultSuppliers = new List<Supplier>();

            defaultSuppliers.Add(new Supplier() { Name = "Standard 1", AddressLine1 = "First Standard" });
            defaultSuppliers.Add(new Supplier() { Name = "Standard 2", AddressLine1 = "Second Standard" });
            defaultSuppliers.Add(new Supplier() { Name = "Standard 3", AddressLine1 = "Third Standard" });

            context.Suppliers.AddRange(defaultSuppliers);

        }
    }
}
