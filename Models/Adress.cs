namespace TravelManagement.Models
{
    public class Adress
    {

        #region "PROPERTIES"

        public string CEP { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
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