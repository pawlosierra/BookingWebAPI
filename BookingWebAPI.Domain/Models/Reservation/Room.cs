using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Domain.Models.Reservation
{
    public class Room
    {
        public int Number { get; set; }
        public decimal PriceNight { get; set; }
        public bool Availability { get; set; }
        public int Capacity { get; set; }
    }
}
