using System.Collections.Generic;

namespace TravelManagement.Models.Repositories
{
    public interface IDriverRepository
    {
        IList<Driver> List();
    }
}