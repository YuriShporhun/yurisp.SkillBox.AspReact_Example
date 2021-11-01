using Domain.Common;

namespace Entities.Domain
{
    public class Destination : IEntity
    {
        public int Id { get; init; }
        public string City { get; init; }
        public string Country { get; init; }

    }
}
