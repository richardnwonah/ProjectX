using Microsoft.EntityFrameworkCore;
using ProjectX.Models;
using System;

namespace ProjectX.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin1", Password = "password1", IsAdmin = true },
                new User { Id = 2, Username = "admin2", Password = "password2", IsAdmin = true }
            );

            modelBuilder.Entity<Shipment>().HasData(
                new Shipment
                {
                    Id = Guid.NewGuid(),
                    Passcode = "1234",
                    ItemName = "Item1",
                    Location = "Location1",
                    OwnersName = "Owner1",
                    OwnersMail = "owner1@example.com",
                    ShipmentWeight = 10,
                    Destination = "Destination1",
                    ShipmentStartDate = DateTime.Now.AddDays(-5),
                    DeliveryDate = DateTime.Now.AddDays(5),
                    Passls = "pass1"
                },
                new Shipment
                {
                    Id = Guid.NewGuid(),
                    Passcode = "5678",
                    ItemName = "Item2",
                    Location = "Location2",
                    OwnersName = "Owner2",
                    OwnersMail = "owner2@example.com",
                    ShipmentWeight = 20,
                    Destination = "Destination2",
                    ShipmentStartDate = DateTime.Now.AddDays(-10),
                    DeliveryDate = DateTime.Now.AddDays(2),
                    Passls = "pass2"
                },
                new Shipment
                {
                    Id = Guid.NewGuid(),
                    Passcode = "abcd",
                    ItemName = "Item3",
                    Location = "Location3",
                    OwnersName = "Owner3",
                    OwnersMail = "owner3@example.com",
                    ShipmentWeight = 30,
                    Destination = "Destination3",
                    ShipmentStartDate = DateTime.Now.AddDays(-7),
                    DeliveryDate = DateTime.Now.AddDays(7),
                    Passls = "pass3"
                },
                new Shipment
                {
                    Id = Guid.NewGuid(),
                    Passcode = "efgh",
                    ItemName = "Item4",
                    Location = "Location4",
                    OwnersName = "Owner4",
                    OwnersMail = "owner4@example.com",
                    ShipmentWeight = 40,
                    Destination = "Destination4",
                    ShipmentStartDate = DateTime.Now.AddDays(-3),
                    DeliveryDate = DateTime.Now.AddDays(10),
                    Passls = "pass4"
                }
            );
        }
    }
}
