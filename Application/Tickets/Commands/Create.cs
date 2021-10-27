using Application.Persistence.Interfaces;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tickets
{
    public class Create
    {
        public class Command : IRequest
        {
            public Ticket Ticket { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IDataAccess _context;

            public Handler(IDataAccess context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Tickets.Add(request.Ticket);
                _ = await _context.SaveAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}
