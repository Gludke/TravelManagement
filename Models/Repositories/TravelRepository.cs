using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagement.Models.Repositories
{
    public class TravelRepository : ITravelRepository
    {
        protected readonly ApplicationContext context;
        protected readonly DbSet<Travel> dbSet;

        public TravelRepository(ApplicationContext contexto)
        {
            this.context = contexto;
            dbSet = contexto.Set<Travel>();
        }

        public void AddTravel(TravelViewModel travelVm)
        {
            //var newTravel = travelVm.Travel;
            //travelVm.Driver.Travels.Add(newTravel);
            //context.SaveChanges();
        }
    }
}
