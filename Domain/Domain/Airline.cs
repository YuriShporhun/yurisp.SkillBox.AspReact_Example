using CSharpFunctionalExtensions;
using Entities.Domain;
using Entities.ValueObjects;
using System.Collections.Generic;

namespace Entities
{
    internal class Airline : Entity<int>
    {
        public AirlineName Name { get; init; }

        public ICollection<Destination> AvailableDestionations { get; init; }
    }
}
