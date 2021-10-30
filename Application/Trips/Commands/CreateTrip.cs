using Application.Persistence.Interfaces;
using Application.Trips.Validators;
using Domain;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Tickets
{
    public class CreateTrip
    {
        public class Command : IRequest
        {
            public Trip Trip { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Trip).SetValidator(new CreateTripValidator());
            }
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
                _context.Tickets.Add(request.Trip);
                _ = await _context.SaveAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}
