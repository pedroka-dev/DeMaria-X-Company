﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using X_Company.Domain.Features;

namespace X_Company.ORM.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("TBPRODUCT");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).HasColumnType("VARCHAR(250)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("VARCHAR(250)").IsRequired();
            builder.Property(p => p.Price).HasColumnType("DOUBLE PRECISION").IsRequired();
            builder.Property(p => p.InStock).HasColumnType("INTEGER").IsRequired();
        }
    }
}
