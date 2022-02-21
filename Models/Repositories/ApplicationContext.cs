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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Adress>().HasKey(t => t.CEP); //o entity registra a classe ao BD e define a sua PK
            modelBuilder.Entity<Adress>().HasOne(adress => adress.Driver).WithOne(driver => driver.Adress);

            modelBuilder.Entity<Driver>().HasOne(driver => driver.Adress).WithOne(adress => adress.Driver);
            modelBuilder.Entity<Driver>().HasOne(driver => driver.Truck).WithOne(adress => adress.Driver);



            //modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            //modelBuilder.Entity<Pedido>().HasMany(p => p.Itens).WithOne(itens => itens.Pedido);
            //modelBuilder.Entity<Pedido>().HasOne(p => p.Cadastro).WithOne(c => c.Pedido).IsRequired();

            //modelBuilder.Entity<ItemPedido>().HasKey(t => t.Id);
            //modelBuilder.Entity<ItemPedido>().HasOne(itp => itp.Pedido);
            //modelBuilder.Entity<ItemPedido>().HasOne(itp => itp.Produto);

            //modelBuilder.Entity<Cadastro>().HasKey(t => t.Id);
            //modelBuilder.Entity<Cadastro>().HasOne(c => c.Pedido);
        }
    }
}
