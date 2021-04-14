using System;
using System.Collections.Generic;

#nullable disable

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public partial class RoomModel
    {
        public RoomModel()
        {
            BookingModels = new HashSet<BookingModel>();
        }

        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public decimal PriceNight { get; set; }
        public bool Availability { get; set; }
        public int Capacity { get; set; }

        public virtual ICollection<BookingModel> BookingModels { get; set; }
    }
}
