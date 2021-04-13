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
        public List<RoomModel> DeserializeListHotelRooms()
        {
            var jsonFile = File.ReadAllText(_path);
            List<RoomModel> hotelRooms = JsonConvert.DeserializeObject<List<RoomModel>>(jsonFile);
            return hotelRooms;
        }
    }
}
