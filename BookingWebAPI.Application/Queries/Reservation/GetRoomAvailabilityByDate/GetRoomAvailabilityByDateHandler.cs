using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookingWebAPI.Application.Queries.Reservation.GetRoomAvailabilityByDate
{
    public class GetRoomAvailabilityByDateHandler : IRequestHandler<GetRoomAvailabilityByDate, IEnumerable<Booking>>
    {
        private readonly IReservationRepository _reservationRepository;

        public GetRoomAvailabilityByDateHandler(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Booking>> Handle(GetRoomAvailabilityByDate request, CancellationToken cancellationToken)
        {
            var rooms = await _reservationRepository.GetAllRooms();
            var roomsAvailabilityByDate = GetRoomsAvailabilityByDate(rooms, request.DateOfEntry);
            return roomsAvailabilityByDate;
        }

        public IEnumerable<Booking> GetRoomsAvailabilityByDate(IEnumerable<Booking> rooms, DateTime dateOfEntry)
        {
            var roomsAvailabilityByData = new List<Booking>();
             
            foreach (var room in rooms)
            {
                if (room.Room.Availability)
                {
                    foreach (var date in room.AvailableDate)
                    {
                        if (date.CheckIn.Equals(dateOfEntry))
                        {
                            roomsAvailabilityByData.Add(room);
                        }
                    }
                }
            }
            return roomsAvailabilityByData;
        }
    }
}
