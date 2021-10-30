using Domain;
using FluentValidation;

namespace Application.Trips.Validators
{
    public class CreateTripValidator : AbstractValidator<Trip>
    {
        public CreateTripValidator()
        {
            RuleFor(x => x.From).NotEmpty();
            RuleFor(x => x.To).NotEmpty();
        }
    }
}
