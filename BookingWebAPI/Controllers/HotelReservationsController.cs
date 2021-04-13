using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using BookingWebAPI.Application.Queries.Reservation.GetAllRoomAvailability;
using BookingWebAPI.Application.Queries.Reservation.GetAllRooms;
using BookingWebAPI.Application.Queries.Reservation.GetRoomAvailabilityByDate;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelReservationsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public HotelReservationsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("getAllRooms")]
        public async Task<IActionResult> GetAllRooms()
        {
            try
            {
                var result = await _mediator.Send(new GetAllRooms());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet("getAllRoomAvailability")]
        public async Task<IActionResult> GetAllRoomAvailability()
        {
            try
            {
                var result = await _mediator.Send(new GetAllRoomAvailability());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }

        [HttpGet("getRoomAvailabilityByDate")]
        public async Task<IActionResult> GetRoomAvailabilityByDate(
                                        [FromQuery(Name = "dateOfEntry")]
                                        [Required(ErrorMessage = "The field dateOfEntry is required.")] 
                                        [RegularExpression(@"\b(?<mm>\d{1,2})/(?<dd>\d{1,2})/(?<yyyy>\d{4})\b", ErrorMessage = "Invalid date format. Requested format is MM/DD/YYYY")]
                                        string dateOfEntry)
        {
            try
            {
                var result = await _mediator.Send(new GetRoomAvailabilityByDate(dateOfEntry));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex);
            }
        }



    }
}
