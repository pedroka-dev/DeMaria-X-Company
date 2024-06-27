using Microsoft.EntityFrameworkCore;

namespace X_Company.ORM
{
    public class XCompanyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=admin;Database=postgres", o => o.UseNetTopologySuite());

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(XCompanyDBContext).Assembly).HasDefaultSchema("custome_schema");
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(decimal));

                foreach (var property in properties)
                    if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue)
                        property.SetColumnType("decimal(18,2)");
            }
        }
    }
}