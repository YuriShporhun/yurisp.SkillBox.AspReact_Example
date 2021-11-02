using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ValueObjects
{
    public class AirlineName : ValueObject<AirlineName>
    {
        public string Value { get; init; }

        public string Country {get; init; }

        public AirlineName(string value)
        {
            Value = value;
        }

        protected override bool EqualsBase(AirlineName valueObject)
        {
            return Value.Equals(valueObject.Value, StringComparison.InvariantCultureIgnoreCase) &&
                   Country.Equals(valueObject.Country, StringComparison.InvariantCultureIgnoreCase);
        }

        protected override int GetHashCodeBase()
        {
            return Value.GetHashCode() ^ Country.GetHashCode();
        }
    }
}
