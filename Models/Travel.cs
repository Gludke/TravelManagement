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
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public DateTime StartTravel { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string DeliveryPlace { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
        public string ExitPlace { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório.")]
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

        public Travel(Driver driver)
        {
            Driver = driver;
        }

        #endregion
    }
}
