using CSharpFunctionalExtensions;
using System.Collections.Generic;

namespace Entities.ValueObjects
{
    public class AirlineName : ValueObject
    {
        public string Value { get; init; }

        public string Country {get; init; }

        public AirlineName(string value)
        {
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
            yield return Country;
        }
    }
}
