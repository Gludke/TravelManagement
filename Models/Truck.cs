using System.ComponentModel.DataAnnotations;

namespace TravelManagement.Models
{
    public class Truck
    {

        #region "PROPERTIES"
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Plate { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Axles { get; set; }//eixos do caminhão
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        #endregion

        #region "CONSTRUCTORS"

        public Truck()
        {

        }

        #endregion

    }
}