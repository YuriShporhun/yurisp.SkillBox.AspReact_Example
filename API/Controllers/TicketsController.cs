using Application;
using Application.Tickets;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class TicketsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Ticket>>> GetTickets()
        {
            return await Mediator.Send(new GetAllTickets.Query());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Ticket>> GetTicket(Guid id)
        {
            return await Mediator.Send(new GetTicketById.Query { Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket newTicket)
        {
            return Ok(await Mediator.Send(new CreateTicket.Command { Ticket = newTicket}));
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> EditTicket(Guid id, Ticket ticket)
        {
            ticket.Id = id;
            return Ok(await Mediator.Send(new EditTicketById.Command { Ticket = ticket }));
        }

    }
}
