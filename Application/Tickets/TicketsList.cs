using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class TicketsList
    {
        public class Query : IRequest<List<Ticket>> { }
        public class Handler : IRequestHandler<Query, List<Ticket>>
        {
            readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Ticket>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Tickets.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}
