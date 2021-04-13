using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public class BookingModel
    {
        public RoomModel Room { get; set; }
        public AvailableDateModel AvailableDate { get; set; }
        public ClientModel Client { get; set; }
    }
}
