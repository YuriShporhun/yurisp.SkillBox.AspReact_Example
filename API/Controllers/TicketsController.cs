using Application;
using Application.Tickets;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class TripsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Trip>>> GetTickets()
        {
            return await Mediator.Send(new GetAllTrips.Query());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Trip>> GetTicket(Guid id)
        {
            return await Mediator.Send(new GetTripById.Query { Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Trip newTicket)
        {
            return Ok(await Mediator.Send(new CreateTrip.Command { Trip = newTicket}));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> EditTicket(Guid id, Trip ticket)
        {
            ticket.Id = id;
            return Ok(await Mediator.Send(new EditTicketTrip.Command { Ticket = ticket }));
        }

    }
}
