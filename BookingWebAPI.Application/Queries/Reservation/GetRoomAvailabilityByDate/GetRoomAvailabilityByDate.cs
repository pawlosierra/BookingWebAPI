using BookingWebAPI.Domain.Models.Reservation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Application.Queries.Reservation.GetRoomAvailabilityByDate
{
    public class GetRoomAvailabilityByDate : IRequest<IEnumerable<Booking>>
    {
        public GetRoomAvailabilityByDate(string dateOfEntry)
        {
            DateOfEntry = DateTime.Parse(dateOfEntry);
        }
        public DateTime DateOfEntry { get; set; }
    }
}
