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
            return await Mediator.Send(new TicketsList.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(Guid id)
        {
            return await Mediator.Send(new TicketDetails.Query { Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateTicket(Ticket newTicket)
        {
            return Ok(await Mediator.Send(new Create.Command { Ticket = newTicket}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditTicket(Guid id, Ticket ticket)
        {
            return Ok(await Mediator.Send(new EditTicket.Command { Ticket = ticket }));
        }

    }
}
