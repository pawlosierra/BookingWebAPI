using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingWebAPI.Application.Queries.Reservation.GetAllRoomAvailability
{
    public class GetAllRoomAvailabilityHandler : IRequestHandler<GetAllRoomAvailability, IEnumerable<Room>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetAllRoomAvailabilityHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Room>> Handle(GetAllRoomAvailability request, CancellationToken cancellationToken)
        {
            var rooms = await _reservationRepository.GetAllRooms();
            return rooms.Where(x => x.Availability == true);
        }
    }
}
