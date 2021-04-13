using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebAPI.DTOs.Reservation
{
    public class BookingResponse
    {
        public RoomResponse Room { get; set; }
        public List<AvailableDateResponse> AvailableDate { get; set; }
        public ClientResponse Client { get; set; }
    }
}
