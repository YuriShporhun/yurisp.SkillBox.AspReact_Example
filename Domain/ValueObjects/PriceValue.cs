using CSharpFunctionalExtensions;
using System.Collections.Generic;

namespace Entities.ValueObjects
{
    public class PriceValue : ValueObject
    {
        private readonly decimal _value;

        private PriceValue(decimal value) 
        {
            _value = value;
        }

        public static Result<PriceValue> Create(decimal value)
        {
            if(value < 0)
            {
                return Result.Failure<PriceValue>("Цена должна быть больше или равной нулю");
            }
            return Result.Success(new PriceValue(value));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return _value;
        }
    }
}
