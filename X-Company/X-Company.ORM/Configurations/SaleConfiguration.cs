using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X_Company.Domain.Features;

namespace X_Company.ORM.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("TBSALE");

            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.Product).WithMany().HasForeignKey("ProductId").IsRequired();
            builder.HasOne(s => s.Client).WithMany().HasForeignKey("ClientId").IsRequired();

            builder.Property(s => s.Quantity).IsRequired();
        }
    }
}
