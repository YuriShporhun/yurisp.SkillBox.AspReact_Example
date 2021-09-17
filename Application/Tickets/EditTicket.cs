using AutoMapper;
using Domain;
using MediatR;
using Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class EditTicket
    {
        public class Command : IRequest
        {
            public Ticket Ticket {  get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            readonly DataContext _context;
            IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var ticket = await _context.Tickets.FindAsync(request.Ticket.Id, cancellationToken);

                _mapper.Map(request.Ticket, ticket);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}
