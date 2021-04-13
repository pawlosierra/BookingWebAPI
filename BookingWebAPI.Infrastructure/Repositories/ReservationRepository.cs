using AutoMapper;
using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Domain.Repositories;
using BookingWebAPI.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookingWebAPI.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly RoomContext _roomContext;
        private readonly IMapper _mapper;

        public ReservationRepository(IMapper mapper)
        {
            _roomContext = new RoomContext();
            _mapper = mapper;
        }

        public async Task<IEnumerable<Booking>> GetAllRooms()
        {
            var availableRooms = _roomContext.DeserializeListHotelRooms();
            var result = _mapper.Map<IEnumerable<Booking>>(availableRooms);
            return result;
        }
    }
}
