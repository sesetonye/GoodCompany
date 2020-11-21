using GoodCompany.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.Entity.EntityTypeConfigurations
{
    public class ProductQuantityConfiguration : IEntityTypeConfiguration<ProductQuantity>
    {
        public void Configure(EntityTypeBuilder<ProductQuantity> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProductId).IsRequired();

        }
    }
}
