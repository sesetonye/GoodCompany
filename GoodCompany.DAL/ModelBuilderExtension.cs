
using GoodCompany.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.DAL
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComputerType>().HasData(
                 new ComputerType
                 {
                     Id = 1,
                     Name = "Desktop PC"
                 },
                 new ComputerType
                 {
                     Id = 2,
                     Name = "Laptop",

                 }
             );

            modelBuilder.Entity<Brand>().HasData(
              new Brand
              {
                  Id = 1,
                  Name = "HP"
              },
              new Brand
              {
                  Id = 2,
                  Name = "Asus",

              },
               new Brand
               {
                   Id = 3,
                   Name = "Apple",

               }
          );
        }
    }
}
