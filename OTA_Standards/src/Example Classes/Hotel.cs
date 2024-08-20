using IOTA_Standards.Interfaces.Members_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTA_Standards.src.Example_Classes
{
    /// <summary>
    /// An example of a class that implements the IReservationMembers that is used to communicated with the IOTA
    /// interface.
    /// </summary>
    public class Hotel : IHotel
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
