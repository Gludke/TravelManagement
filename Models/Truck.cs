namespace TravelManagement.Models
{
    public class Truck
    {

        #region "PROPERTIES"
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Plate { get; set; }
        public string Axles { get; set; }//eixos do caminhão
        public int DriverId { get; set; }//chave estrangeira
        public Driver Driver { get; set; }

        #endregion

        #region "CONSTRUCTORS"


        #endregion

    }
}