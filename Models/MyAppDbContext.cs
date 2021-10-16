using Microsoft.EntityFrameworkCore;
using System;

namespace MyAdvertiseAgent.Models
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<ContentTypePrice> ContentPrices { get; set; }
        public DbSet<PageTypePrice> PagePrices { get; set; }
        public DbSet<AdvOrder> AdvOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                FirstName = "Uncle",
                LastName = "Bob",
                Email = "uncle.bob@gmail.com",
                DateOfBirth = new DateTime(1979, 04, 25),
                PhoneNumber = "999-888-7777"

            }, new Employee
            {
                FirstName = "Jan",
                LastName = "Kirsten",
                Email = "jan.kirsten@gmail.com",
                DateOfBirth = new DateTime(1981, 07, 13),
                PhoneNumber = "111-222-3333"
            });
        }
    }
}
