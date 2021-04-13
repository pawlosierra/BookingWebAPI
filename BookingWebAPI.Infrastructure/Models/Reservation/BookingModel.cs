using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public class BookingModel
    {
        public RoomModel RoomModel { get; set; }
        public virtual ICollection<AvailableDateModel> AvailableDate { get; set; }
        //public ClientModel Client { get; set; }
    }
}
