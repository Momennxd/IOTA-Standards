using IOTA_Standards;
using Microsoft.AspNetCore.Mvc;


namespace IOTA_Inerfaces
{


    /// <summary>
    /// This interface is implemented by the OTAs who integrate with this channel manager,
    /// It contains the main endpoints that are used by the CM to standerlize the communication between the CM and OTAs.
    ///<para> It should be implemented in a controller used to communicate with the CM.</para>
    /// </summary>
    public interface IOTA
    {



        /// <summary>
        /// This async method is used to make the CM reserve an accomadation from the OTA.
        /// <para>The endpoint URL should be a combination of the OTA base URL and the endpoint name.</para>
        /// <para>You can get all the endpoint names from the official documantations.</para>
        /// </summary>
        /// <param name="reservation">
        /// Reservation parameter is an object from a class that implements the IReservation interface.
        /// </param>
        /// <returns>
        /// An object from a class that implements the IReservation interface.
        /// </returns>
        public Task<ActionResult<IReservationMembers>> ReserveAccomadation(CM_Comunicators.Reservation reservation);



    }



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




    }









}
