using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public class AvailableDateModel
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
