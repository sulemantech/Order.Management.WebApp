using Microsoft.EntityFrameworkCore;
using Order.Management.WebApp.Data;

namespace Order.Management.WebApp.Models
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasData(
        new Supplier
        {
            
            //Name = "William",
            //LastName = "Shakespeare"
        }
    );
        }*/
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
