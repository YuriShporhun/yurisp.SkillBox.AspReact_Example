using Entities.Domain;
using FluentValidation;

namespace Application.Trips.Validators
{
    public class CreateTripValidator : AbstractValidator<Trip>
    {
        public CreateTripValidator()
        {
            RuleFor(x => x.LeavingFrom).NotEmpty();
            RuleFor(x => x.GoingTo).NotEmpty();
        }
    }
}
