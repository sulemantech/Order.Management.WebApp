using System;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Management.WebApp.Data
{
    public class SupplierService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<Supplier[]> GetSupplierAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Supplier
            {
                Name ="Martin",
                AddressLine ="Street 501",
                AddressLine1="House 5",
                City = "Islamabad",
                PostalCode ="44000",
                State ="Pakistan"

            }).ToArray());
        }
    }
}
