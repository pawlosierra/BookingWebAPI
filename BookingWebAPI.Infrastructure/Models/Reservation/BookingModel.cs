using System;
using System.Collections.Generic;

#nullable disable

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public partial class BookingModel
    {
        public int Id { get; set; }
        public int RoomModelId { get; set; }
        public int AvailableDateModelId { get; set; }

        public virtual AvailableDateModel RoomModel { get; set; }
        public virtual RoomModel RoomModelNavigation { get; set; }
    }
}
