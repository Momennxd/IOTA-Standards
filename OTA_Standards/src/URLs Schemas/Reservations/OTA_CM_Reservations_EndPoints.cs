using IOTA_Standards.Interfaces.OTAs_CMs.Reservations;
using IOTA_Standards.src.Example_Classes;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTA_Standards.src.URL_schemas.Reservations
{

    /// <summary>
    //-This static class is used to store the endpoints const names.
    //<para>-Eeach endpoint in the controller that implements the ICM_OTA_Reservations 
    //should make its route {OTA_baseURL + endpoint Name}</para>
    /// </summary>
    
    public static class OTA_CM_Reservations_EndPoints
    {
        /// <summary>
        /// This const name is used to declare the route name of the controller that implements the ICM_OTA_Reservations interface.
        /// </summary>
        public const string ReservationsControllerRoute = @"OTACM/Accomadations/Reservations";


        public const string PostReservationEndPoint = @"Reserve";

        public const string PutReservationEndPoint = @"PutReservation";

        public const string PatchReservationEndPoint = @"PatchReservation";

    }




}
