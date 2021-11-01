using Domain.Common;
using Entities.Domain;
using Entities.ValueObjects;
using System.Collections.Generic;

namespace Entities
{
    internal class Airline : IEntity
    {
        public int Id { get; init; }

        public AirlineName Name { get; init; }

        public ICollection<Destination> AvailableDestionations { get; init; }
    }
}
