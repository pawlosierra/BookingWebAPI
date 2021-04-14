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
        private readonly RoomContext _roomContext;
        private readonly BookingContext _bookingContext;
        private readonly IMapper _mapper;

        public ReservationRepository(IMapper mapper, BookingContext bookingContext)
        {
            _roomContext = new RoomContext();
            _mapper = mapper;
            _bookingContext = bookingContext;
        }

        public async Task<IEnumerable<Booking>> GetAllRooms()
        {
            //await _bookingContext.Database.EnsureCreatedAsync();
            //var availableRooms = _roomContext.DeserializeListHotelRooms();
            //foreach (var room in availableRooms)
            //{
            //    _bookingContext.BookingModels.Add(new BookingModel
            //    {
            //        RoomModel = room.RoomModel,
            //        AvailableDate = room.AvailableDate
            //    });
            //}
            //await _bookingContext.SaveChangesAsync();
            var availableRooms = await _bookingContext.BookingModels.ToListAsync();
            var result = _mapper.Map<IEnumerable<Booking>>(availableRooms);
            return result;
        }
    }
}
