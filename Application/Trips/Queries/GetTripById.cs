using Application.Persistence.Interfaces;
using Domain;
using Entities.Domain;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class GetTripById
    {
        public class Query : IRequest<Trip>
        {
            public Guid Id {  get; set; }
        }

        public class Handler : IRequestHandler<Query, Trip>
        {
            private readonly IDataAccess _dataAccess;
            public Handler(IDataAccess context)
            {
                _dataAccess = context;
            }
            public async Task<Trip> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataAccess.Tickets.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
