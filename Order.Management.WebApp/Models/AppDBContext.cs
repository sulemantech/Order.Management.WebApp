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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().HasOne<State>().WithOne().HasForeignKey<Supplier>(x => x.StateId);
        }
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
