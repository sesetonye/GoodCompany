using GoodCompany.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.Entity.EntityTypeConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.HasAlternateKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired();
            builder.HasOne(p => p.ProductQuantity)
                .WithOne(pq => pq.Product)
                .HasForeignKey<ProductQuantity>(pq => pq.ProductId);

            builder.HasOne(p => p.ProductProperty)
                .WithOne(pp => pp.Product)
                .HasForeignKey<ProductProperty>(pq => pq.ProductId);
        }
    }
}
