using AutoMapper;
using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.DTOs.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingWebAPI.Mappers
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<Booking, BookingResponse>();

            CreateMap<AvailableDate, AvailableDateResponse>();

            CreateMap<Client, ClientResponse>();

            CreateMap<Room, RoomResponse>();
        }
    }
}
