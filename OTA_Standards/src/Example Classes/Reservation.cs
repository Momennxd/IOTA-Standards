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
    public class Reservation : IReservation
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

        public Reservation()
        {
            ReservationID = -1;
            State = 0;
            Discription = string.Empty;
            Check_in = DateTime.MinValue;
            Check_out = DateTime.MinValue;
            AccommodationSerialNumber = string.Empty;
            HotelSerialNumber = string.Empty;
            NumberOfPeople = 0;
            NumberOfAccommodations = 0;
            ReservationDate = DateTime.MinValue;
            BuisnessName = string.Empty;

        }
    }


}
