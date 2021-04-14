using BookingWebAPI.Domain.Models.Reservation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookingWebAPI.Domain.Repositories
{
    public interface IReservationRepository
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task<IEnumerable<Booking>> GetAvalabilityRoomsByData();
    }
}
