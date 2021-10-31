using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ValueObjects
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        public override bool Equals(object obj)
        {
            if (obj is not T valueObject)
            {
                return false;
            }

            return EqualsBase(valueObject);
        }

        public override int GetHashCode()
        {
            return GetHashCodeBase();
        }

        protected abstract bool EqualsBase(T valueObject);
        protected abstract int GetHashCodeBase();
    }
}
