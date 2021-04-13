using BookingWebAPI.Domain.Models.Reservation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Application.Queries.Reservation.GetAllRoomAvailability
{
    public class GetAllRoomAvailability : IRequest<IEnumerable<Booking>>
    {
    }
}
