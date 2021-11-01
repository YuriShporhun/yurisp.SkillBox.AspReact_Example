using CSharpFunctionalExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ValueObjects
{
    public class Money : ValueObject<Money>
    {
        private readonly decimal _value;

        private Money(decimal value) 
        {
            _value = value;
        }

        public static Result<Money> Create(decimal value)
        {
            if(value < 0)
            {
                return Result.Failure<Money>("Цена должна быть больше или равной нулю");
            }
            return Result.Success(new Money(value));
        }

        protected override bool EqualsBase(Money valueObject)
        {
           return _value.Equals(valueObject._value);
        }

        protected override int GetHashCodeBase()
        {
            return GetHashCode();
        }
    }
}
