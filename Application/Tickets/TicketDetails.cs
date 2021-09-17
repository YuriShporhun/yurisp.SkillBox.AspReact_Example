using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class TicketDetails
    {
        public class Query : IRequest<Ticket>
        {
            public Guid Id {  get; set; }
        }

        public class Handler : IRequestHandler<Query, Ticket>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<Ticket> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Tickets.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
