using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace IOTA_Standards.Interfaces.OTAs_CMs.Reservations
{
    /// <summary>
    /// This interface is implemented by the classes that communicate with the IOTA reservations endpoints
    /// to manage reservations.
    /// </summary>
    public interface IReservationMembers
    {
        public int ReservationID { get; set; }

        public byte State { get; set; }

        public string Discription { get; set; }

        public DateTime Check_in { get; set; }

        public DateTime Check_out { get; set; }

        public string AccommodationSerialNumber { get; set; }

        public string HotelSerialNumber { get; set; }

        public byte NumberOfPeople { get; set; }

        public short NumberOfAccommodations { get; set; }

        public DateTime ReservationDate { get; set; }

        public string BuisnessName { get; set; }


    }









}
