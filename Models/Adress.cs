using System.ComponentModel.DataAnnotations;

namespace TravelManagement.Models
{
    public class Adress
    {

        #region "PROPERTIES"
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CEP { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string District { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string City { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Country { get; set; }
        public int DriverId { get; set; }//chave estrangeira
        public Driver Driver { get; set; }

        #endregion

        #region "CONSTRUCTORS"

        public Adress()
        {

        }

        #endregion
    }
}