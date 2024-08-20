using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace IOTA_Standards.Interfaces.Members_Interfaces
{
    /// <summary>
    /// This interface is implemented by the classes that communicate with the hotel managment endpoints.
    /// </summary>
    public interface IHotel
    {
        public int HotelID { get; set; }

        public string HotelName { get; set; }

        public string Discription { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }

        public float DistanceFromBeach { get; set; }

        public float DistanceFromCenter { get; set; }

        public string HotelSerialNumber { get; set; }

      


    }









}
