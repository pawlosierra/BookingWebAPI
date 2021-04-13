using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public class RoomModel
    {
        public int Number { get; set; }
        public decimal PriceNight { get; set; }
        public bool Availability { get; set; }
        public int Capacity { get; set; }
    }
}
