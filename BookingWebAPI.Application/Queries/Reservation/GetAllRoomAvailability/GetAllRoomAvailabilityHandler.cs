using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingWebAPI.Application.Queries.Reservation.GetAllRoomAvailability
{
    public class GetAllRoomAvailabilityHandler : IRequestHandler<GetAllRoomAvailability, IEnumerable<Booking>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetAllRoomAvailabilityHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Booking>> Handle(GetAllRoomAvailability request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
