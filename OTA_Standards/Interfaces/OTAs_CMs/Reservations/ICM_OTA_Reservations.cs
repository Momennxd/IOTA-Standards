using IOTA_Standards.src.Reservations;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace IOTA_Standards.Interfaces.OTAs_CMs.Reservations
{


    /// <summary>
    /// This interface is implemented by the OTAs and channel managers,
    /// It contains the main endpoints that are consumpted by the CM and OTAs
    /// to standerlize the communication between them.
    /// <para>-It should be implemented by a controller in the CMs and OTAs that manages reservations.</para>
    /// <para>-The endpoint URL should be a combination of the base URL and the endpoint name.</para>
    /// <para>-You can get all the endpoint names from the official documantations.</para>
    /// </summary>
    public interface ICM_OTA_Reservations
    {


        /// <summary>
        /// This async method is used to make (POST) a reservation from a CM or OTA.     
        /// </summary>
        /// <param name="reservation">
        /// Reservation parameter is an object from a class that implements the IReservation interface.
        /// </param>
        /// <returns>
        /// True if the reservation was successfull, False if Not.
        /// </returns>
        public Task<ActionResult<bool>> ReserveAccomadation(Reservation reservation);


        /// <summary>
        /// This async method is used to update (PUT) a reservation.     
        /// </summary>
        /// <param name="reservation">
        /// Reservation parameter is an object from a class that implements the IReservation interface.
        /// </param>
        /// <returns>
        /// An object from a class that implements the IReservation interface.
        /// </returns>
        public Task<ActionResult<IReservationMembers>> UpdateReservation(Reservation reservation);



        /// <summary>
        /// This async method is used to update (PATCH) a reservation.      
        /// </summary>
        /// <param name="jsonPatchReservation">
        /// Reservation parameter is an object from a class that implements the IReservation interface.
        /// </param>
        /// <returns>
        /// An object from a class that implements the IReservation interface.
        /// </returns>
        public Task<ActionResult<IReservationMembers>> PatchReservation(JsonPatchDocument<Reservation> jsonPatchReservation);




        //IMPORTANT:
        //There is no delete reservation endpoint, but you can change the state to "Cancelled" by the patch endpoint.






    }



}
