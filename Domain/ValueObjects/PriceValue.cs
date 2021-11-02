using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ValueObjects
{
    public class PriceValue : ValueObject<PriceValue>
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

        protected override bool EqualsBase(PriceValue valueObject)
        {
           return _value.Equals(valueObject._value);
        }

        protected override int GetHashCodeBase()
        {
            return GetHashCode();
        }
    }
}
