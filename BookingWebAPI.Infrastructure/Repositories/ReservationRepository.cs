using AutoMapper;
using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Domain.Repositories;
using BookingWebAPI.Infrastructure.Data;
using BookingWebAPI.Infrastructure.Models.Reservation;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebAPI.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        //private readonly RoomContext _roomContext;
        private readonly BookingContext _bookingContext;
        private readonly IMapper _mapper;

        public ReservationRepository(IMapper mapper, BookingContext bookingContext)
        {
            _mapper = mapper;
            _bookingContext = bookingContext;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            var rooms = await _bookingContext.RoomModels.ToListAsync();
            var result = _mapper.Map<IEnumerable<Room>>(rooms);
            return result;
        }

        public async Task<IEnumerable<Booking>> GetAvalabilityRoomsByData()
        {
            //var lst = new List<Booking>();
            //var booking = await _bookingContext.BookingModels.ToListAsync();
            //var booking = from a in _bookingContext.RoomModels
            //              join s in _bookingContext.AvailableDateModels 
                          
            return null;
        }
    }
}
