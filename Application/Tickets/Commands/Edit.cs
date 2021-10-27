using Application.Interfaces;
using AutoMapper;
using Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tickets
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Domain.Ticket Ticket {  get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IDataAccess _dataAccess;
            private readonly IMapper _mapper;

            public Handler(IDataAccess context, IMapper mapper)
            {
                _mapper = mapper;
                _dataAccess = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var ticket = await _dataAccess.Tickets.FindAsync(request.Ticket.Id);

                _mapper.Map(request.Ticket, ticket);
 
                _ = await _dataAccess.SaveAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
