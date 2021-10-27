using Application.Persistence.Interfaces;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tickets
{
    public class GetAllTickets
    {
        public class Query : IRequest<List<Ticket>> { }
        public class Handler : IRequestHandler<Query, List<Ticket>>
        {
            private readonly IDataAccess _dataAccess;

            public Handler(IDataAccess context)
            {
                _dataAccess = context;
            }

            public async Task<List<Ticket>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataAccess.Tickets.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}
