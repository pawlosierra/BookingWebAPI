using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Models.Reservation
{
    public class ClientModel
    {
        public string Passport { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellPhoneNumber { get; set; }
    }
}
