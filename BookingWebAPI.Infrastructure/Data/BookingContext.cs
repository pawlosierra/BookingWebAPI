using BookingWebAPI.Infrastructure.Models.Reservation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingWebAPI.Infrastructure.Data
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
        }
        public DbSet<BookingModel> BookingModels { get; set; }
    }
}
