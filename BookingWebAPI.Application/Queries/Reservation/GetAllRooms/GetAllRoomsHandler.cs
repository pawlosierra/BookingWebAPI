using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingWebAPI.Application.Queries.Reservation.GetAllRooms
{
    public class GetAllRoomsHandler : IRequestHandler<GetAllRooms, IEnumerable<Booking>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetAllRoomsHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Booking>> Handle(GetAllRooms request, CancellationToken cancellationToken)
        {
            var rooms = await _reservationRepository.GetAllRooms();
            return rooms;
        }
    }
}
