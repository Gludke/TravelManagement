using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelManagement.Models
{
    public class Driver
    {
        #region "PROPERTIES"
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Name { get; set; }
        //public int TruckId { get; set; }
        public Truck Truck { get; set; }
        //public int AdressId { get; set; }
        public Adress Adress { get; set; }
        public ICollection<Travel> Travels { get; set; } = new List<Travel>();

        #endregion

        #region "CONSTRUCTORS"

        public Driver()
        {
            this.Truck = new Truck
            {
                Driver = this
            };
            this.Adress = new Adress
            {
                Driver = this
            };
        }

        #endregion
    }
}