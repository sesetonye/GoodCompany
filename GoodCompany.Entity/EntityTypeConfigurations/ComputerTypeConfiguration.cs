﻿using GoodCompany.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.Entity.EntityTypeConfigurations
{
    public class ComputerTypeConfiguration : IEntityTypeConfiguration<ComputerType>
    {
        public void Configure(EntityTypeBuilder<ComputerType> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
        }
    }
}
