using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelManagement.Models
{
    public class Driver
    {
        #region "PROPERTIES"
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int TruckId { get; set; }//chave estrangeira
        public Truck Truck { get; set; }
        public int AdressId { get; set; }//chave estrangeira
        public Adress Adress { get; set; }
        public IList<Travel> Travels { get; set; }

        #endregion

        #region "CONSTRUCTORS"

        public Driver()
        {

        }

        #endregion
    }
}