using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebAPI.DTOs.Reservation
{
    public class AvailableDateResponse
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}
