using Application.Persistence.Interfaces;
using Domain;
using Entities.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tickets
{
    public class GetAllTrips
    {
        public class Query : IRequest<List<Trip>> { }
        public class Handler : IRequestHandler<Query, List<Trip>>
        {
            private readonly IDataAccess _dataAccess;

            public Handler(IDataAccess context)
            {
                _dataAccess = context;
            }

            public async Task<List<Trip>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataAccess.Tickets.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}
