using GoodCompany.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.Entity.EntityTypeConfigurations
{
    public class ProductPropertyConfiguration : IEntityTypeConfiguration<ProductProperty>
    {
        public void Configure(EntityTypeBuilder<ProductProperty> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.ProductId).IsRequired();
            //builder.Property(p=>p.).
        }
    }
}
