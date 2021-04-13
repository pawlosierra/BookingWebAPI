using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebAPI.DTOs.Reservation
{
    public class ClientResponse
    {
        public string Passport { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellPhoneNumber { get; set; }
    }
}
