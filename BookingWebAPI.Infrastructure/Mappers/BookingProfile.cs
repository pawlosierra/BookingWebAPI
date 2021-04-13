using AutoMapper;
using BookingWebAPI.Domain.Models.Reservation;
using BookingWebAPI.Infrastructure.Models.Reservation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Mappers
{
    public class BookingProfile : Profile
    {
        public BookingProfile()
        {
            CreateMap<BookingModel, Booking>()
            .ForMember(dest => dest.Room, opt => opt.MapFrom(src => src.RoomModel));
            //.ForMember(dest => dest.AvailableDate, opt => opt.MapFrom(src => src.AvailableDateModel));

            CreateMap<AvailableDateModel, AvailableDate>();
                //.ForMember(dest => dest.CheckIn, opt => opt.MapFrom(src => DateTime.Parse(src.CheckIn)))
                //.ForMember(dest => dest.CheckOut, opt => opt.MapFrom(src => DateTime.Parse(src.CheckOut)));

            //CreateMap<ClientModel, Client>();

            CreateMap<RoomModel, Room>();
        }
    }
}
