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
    public class GetAllRoomsHandler : IRequestHandler<GetAllRooms, IEnumerable<Room>>
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly Room _room;
        public GetAllRoomsHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
            _room = new Room();
        }

        public async Task<IEnumerable<Room>> Handle(GetAllRooms request, CancellationToken cancellationToken)
        {
            var bookings = await _reservationRepository.GetAllRooms();
            var rooms = SearchAllHotelRooms(bookings);
            return rooms;
        }

        public IEnumerable<Room> SearchAllHotelRooms(IEnumerable<Booking> bookings)
        {
            var hotelRooms = new List<Room>();
            foreach (var room in bookings)
            {
                hotelRooms.Add(room.Room);
            }
            return hotelRooms;
        }
    }
}
