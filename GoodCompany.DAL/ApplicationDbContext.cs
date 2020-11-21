
using GoodCompany.Entity;
using GoodCompany.Entity.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GoodCompany.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<ComputerType> ComputerType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductQuantity> ProductQuantity { get; set; }
        public virtual DbSet<ProductProperty> ProductProperty { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new ComputerTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductQuantityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductPropertyConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.Seed();
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../GoodCompany.Web/appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DatabaseConnection");
            builder.UseSqlServer(connectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }
}
