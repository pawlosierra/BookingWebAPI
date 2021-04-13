using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Domain.Models.Reservation
{
    public class AvailableDate
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
