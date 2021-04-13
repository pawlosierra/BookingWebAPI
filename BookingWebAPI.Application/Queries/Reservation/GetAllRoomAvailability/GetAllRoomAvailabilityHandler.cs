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
    public class GetAllRoomAvailabilityHandler : IRequestHandler<GetAllRoomAvailability, IEnumerable<Booking>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetAllRoomAvailabilityHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Booking>> Handle(GetAllRoomAvailability request, CancellationToken cancellationToken)
        {
            var rooms = await _reservationRepository.GetAllRooms();
            var roomsAvailability = SearchRoomsAvailability(rooms);
            return roomsAvailability;
        }
        public IEnumerable<Booking> SearchRoomsAvailability(IEnumerable<Booking> rooms)
        {
            var roomsAvailability = new List<Booking>();
            foreach (var room in rooms)
            {
                if (room.Room.Availability)
                {
                    roomsAvailability.Add(room);
                }
            }
            return roomsAvailability;
        }
    }
}
