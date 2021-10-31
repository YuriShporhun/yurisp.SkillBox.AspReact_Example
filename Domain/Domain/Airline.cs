using Domain.Common;
using Entities.Domain;
using Entities.ValueObjects;
using System.Collections.Generic;

namespace Entities
{
    internal class Airline : IEntity
    {
        public int Id { get; set; }

        public AirlineName Name { get; set; }

        public ICollection<Destination> AvailableDestionations { get; set; }
    }
}
