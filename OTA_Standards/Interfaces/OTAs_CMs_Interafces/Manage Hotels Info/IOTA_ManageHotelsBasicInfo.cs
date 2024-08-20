using IOTA_Standards.Interfaces.Members_Interfaces;
using IOTA_Standards.src.Example_Classes;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OTA_Standards.src.URL_schemas.Hotels;
using OTA_Standards.src.URL_schemas.Reservations;


namespace IOTA_Standards.Interfaces.OTAs_CMs_Interafces.Reservations
{

    /// <summary>
    /// This interface is implemented by the OTAs and channel managers,
    /// It contains the main endpoints that are consumpted by the CM and HMS
    /// to standerlize the communication between them.
    /// <para>-It should be implemented by a controller in the CMs and OTAs that manages Hotel basic info.</para>
    /// <para>-The endpoint URL should be a combination of the base URL and the endpoint name.</para>
    /// <para>-You can get all the endpoint names from the official documantations.</para>
    /// </summary>
    public interface IOTA_ManageHotelsBasicInfo
    {

        /// <summary>
        /// This async method is used to create (POST) a new hotel form the HMS or OTA.     
        /// </summary>
        /// <param name="hotel">
        /// hotel parameter is an object from a class that implements the IHotel interface.
        /// </param>
        /// <returns>
        /// True if the hotel was added successfull, False if Not.
        /// </returns>

        [Route(@$"{OTA_CM_Hotels_EndPoints.PostHotelEndPoint}")]
        public Task<ActionResult<bool>> AddNewHotel(Hotel hotel);



        /// <summary>
        /// This async method is used to update (PUT) hotel info.     
        /// </summary>
        /// <param name="hotel">
        /// hotel parameter is an object from a class that implements the IHotel interface.
        /// </param>
        /// <returns>
        /// An object from a class that implements the IHotel interface.
        /// </returns>
        [Route(@$"{OTA_CM_Hotels_EndPoints.PutHotelEndPoint}")]
        public Task<ActionResult<IHotel>> UpdateHotel(Hotel hotel);



        /// <summary>
        /// This async method is used to update (PATCH) hotel info.     
        /// </summary>
        /// <param name="jsonPatchReservation">
        /// hotel parameter is an object from a class that implements the IHotel interface.
        /// </param>
        /// <returns>
        /// An object from a class that implements the IHotel interface.
        /// </returns>

        [Route(@$"{OTA_CM_Hotels_EndPoints.PatchHotelEndPoint}")]
        public Task<ActionResult<IHotel>> PatchHotel(JsonPatchDocument<Hotel> jsonPatchHotel);




    }



}
