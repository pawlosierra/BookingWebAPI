using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using BookingWebAPI.Application.Queries.Reservation.GetAllRoomAvailability;
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

        [HttpGet("getAllRoom")]
        public async Task<IActionResult> GetAllRoom()
        {
            try
            {
                return Ok();
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

        
    }
}
