using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Domain.Models.Reservation
{
    public class Booking
    {
        public Room Room { get; set; }
        public List<AvailableDate> AvailableDate { get; set; }
        public Client Client { get; set; }
    }
}
