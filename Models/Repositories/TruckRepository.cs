using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagement.Models.Repositories
{
    public class TruckRepository : ITruckRepository
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<Truck> dbSet;

        public TruckRepository(ApplicationContext contexto)
        {
            this.context = contexto;
            dbSet = contexto.Set<Truck>();
        }
    }
}
