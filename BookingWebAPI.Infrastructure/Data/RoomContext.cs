using BookingWebAPI.Infrastructure.Models.Reservation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BookingWebAPI.Infrastructure.Data
{
    public class RoomContext
    {
        private readonly string _path = @"C:\Users\JuanPawloSierra\source\repos\Projects\BookingWebAPI\BookingWebAPI.Infrastructure\Data\Json\Rooms.json";
        public List<BookingModel> DeserializeListHotelRooms()
        {
            var jsonFile = File.ReadAllText(_path);
            List<BookingModel> hotelRooms = JsonConvert.DeserializeObject<List<BookingModel>>(jsonFile);
            return hotelRooms;
        }
    }
}
