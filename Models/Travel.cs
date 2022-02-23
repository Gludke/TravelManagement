using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelManagement.Models
{
    public class Travel
    {

        #region "PROPERTIES"
        [Key]
        public int Id { get; set; }
        public DateTime StartTravel { get; set; }
        public string DeliveryPlace { get; set; }
        public string ExitPlace { get; set; }
        public double KmBetweenCities { get; set; }
        public int DriverId { get; set; }//chave estrangeira
        [Required]
        public Driver Driver { get; set; }

        #endregion

        #region "CONSTRUCTORS"

        public Travel(DateTime startTravel, string deliveryPlace, string exitPlace, double kmBetweenCities, Driver driver)
        {
            StartTravel = startTravel;
            DeliveryPlace = deliveryPlace;
            ExitPlace = exitPlace;
            KmBetweenCities = kmBetweenCities;
            Driver = driver;
        }

        public Travel()
        {

        }

        #endregion
    }
}
