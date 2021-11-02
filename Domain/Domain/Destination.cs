using CSharpFunctionalExtensions;

namespace Entities.Domain
{
    public class Destination : Entity<int>
    {
        public string City { get; init; }
        public string Country { get; init; }

    }
}
