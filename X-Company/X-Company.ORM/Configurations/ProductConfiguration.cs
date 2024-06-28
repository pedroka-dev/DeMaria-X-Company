using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using X_Company.Domain.Features;

namespace X_Company.ORM.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("TBCLIENT");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasColumnType("VARCHAR(250)").IsRequired();
            builder.Property(p => p.Address).HasColumnType("VARCHAR(250)").IsRequired();
            builder.Property(p => p.Phone).HasColumnType("VARCHAR(250)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(250)").IsRequired();
        }
    }
}
