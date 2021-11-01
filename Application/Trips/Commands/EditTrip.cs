using Application.Persistence.Interfaces;
using AutoMapper;
using Entities.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tickets
{
    public class EditTrip
    {
        public class Command : IRequest
        {
            public Trip Trip { get; set; }
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
                var ticket = await _dataAccess.Tickets.FindAsync(request.Trip.Id);

                _mapper.Map(request.Trip, ticket);
 
                _ = await _dataAccess.SaveAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
