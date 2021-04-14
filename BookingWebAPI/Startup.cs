using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingWebAPI.Application.Queries.Reservation.GetAllRoomAvailability;
using BookingWebAPI.Domain.Repositories;
using BookingWebAPI.Infrastructure.Data;
using BookingWebAPI.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BookingWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(typeof(GetAllRoomAvailabilityHandler).Assembly);
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddDbContext<BookingContext>(opt =>
            {
                opt.UseSqlServer("Server=DESKTOP-9LJ95CE; Database=Booking; Trusted_Connection=True; User=sa; Password=root;");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
