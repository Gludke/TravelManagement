using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagement.Models.Repositories
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Travel> Travel { get; set; }
        public DbSet<Truck> Truck { get; set; }
        public DbSet<Adress> Adress { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Driver
            modelBuilder.Entity<Driver>().HasKey(t => t.Id);
            modelBuilder.Entity<Driver>()
                .HasOne<Adress>(driver => driver.Adress)
                .WithOne(a => a.Driver)
                .HasForeignKey<Adress>(a => a.DriverId);

            modelBuilder.Entity<Driver>()
                .HasOne(driver => driver.Truck)
                .WithOne(a => a.Driver)
                .HasForeignKey<Truck>(d => d.DriverId);

            modelBuilder.Entity<Driver>().HasMany(travels => travels.Travels).WithOne(d => d.Driver);
            //Adress:
            modelBuilder.Entity<Adress>().HasKey(t => t.Id);
            modelBuilder.Entity<Adress>()
                .HasOne<Driver>(a => a.Driver)
                .WithOne(d => d.Adress);

            //Truck:
            modelBuilder.Entity<Truck>().HasKey(t => t.Id);
            modelBuilder.Entity<Truck>()
                .HasOne(driver => driver.Driver)
                .WithOne(driver => driver.Truck);

            //Travel:
            modelBuilder.Entity<Travel>().HasKey(t => t.Id);
            modelBuilder.Entity<Travel>().HasOne(driver => driver.Driver).WithMany(t => t.Travels);
        }
    }
}
