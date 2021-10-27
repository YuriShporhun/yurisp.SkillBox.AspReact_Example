using Application.Persistence.Interfaces;
using Domain;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class GetTicketById
    {
        public class Query : IRequest<Ticket>
        {
            public Guid Id {  get; set; }
        }

        public class Handler : IRequestHandler<Query, Ticket>
        {
            private readonly IDataAccess _dataAccess;
            public Handler(IDataAccess context)
            {
                _dataAccess = context;
            }
            public async Task<Ticket> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataAccess.Tickets.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
