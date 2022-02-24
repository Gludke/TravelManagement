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
            return dbSet.ToList();
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
    }
}
