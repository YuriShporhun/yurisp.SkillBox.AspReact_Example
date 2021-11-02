using CSharpFunctionalExtensions;
using Entities.ValueObjects;

namespace Entities.Domain
{
    public class Price : Entity<int>
    {
        public Currency Currency { get; init; }
        public PriceValue Value { get; set; }
    }
}
