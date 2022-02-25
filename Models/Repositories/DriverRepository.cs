using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagement.Models.Repositories
{
    public class DriverRepository : IDriverRepository
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<Driver> dbSet;

        public DriverRepository(ApplicationContext contexto)
        {
            this.context = contexto;
            dbSet = contexto.Set<Driver>();
        }

        public IList<Driver> List()
        {
            return dbSet
                .OrderBy(d => d.Name)
                .Include(t => t.Truck)
                .Include(a => a.Adress)
                .ToList();
        }

        public void Add(Driver driver)
        {
            if (driver == null)
            {
                throw new ArgumentException();
            }
            dbSet.Add(driver);
            context.SaveChanges();
        }

        public Driver SearchDriverWithId(int idDriver)
        {
            var driver = dbSet
                .Include(t => t.Truck)
                .Include(a => a.Adress)
                .Include(t => t.Travels)
                .FirstOrDefault(d => d.Id == idDriver);

            if (driver == null)
                throw new ArgumentException("motorista não encontrado.");

            return driver;
        }

        public void Remove(int idDriver)
        {
            var driver = SearchDriverWithId(idDriver);
            if(driver != null)
            {
                dbSet.Remove(driver);
                context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("motorista não encontrado.");
            }
            
        }
    }
}
