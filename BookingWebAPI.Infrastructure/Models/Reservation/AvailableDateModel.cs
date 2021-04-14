using System;
using System.Collections.Generic;

#nullable disable

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public partial class AvailableDateModel
    {
        public AvailableDateModel()
        {
            BookingModels = new HashSet<BookingModel>();
        }

        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public virtual ICollection<BookingModel> BookingModels { get; set; }
    }
}
