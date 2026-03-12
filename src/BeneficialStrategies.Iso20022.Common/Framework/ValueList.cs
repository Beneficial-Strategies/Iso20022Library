using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022
{
    /// <summary>
    /// Extends the normal list by using value-based equality.  Also uses Iso20022 serialization.
    /// </summary>
    /// <typeparam name="T">The data type of items in the collection.</typeparam>
    public class ValueList<T> : List<T>
    {
        /// <inheritdoc />
        public ValueList()
        {

        }
        
        /// <inheritdoc />
        public ValueList(IEnumerable<T> collection) : base(collection)
        {
        }

        /// <inheritdoc />
        public ValueList(int capacity) : base(capacity)
        {
        }

        /// <inheritdoc />
        public override bool Equals(object? other)
        {
            if (other is null) return false;
            if (!(other is IEnumerable<T> enumerable)) return false;
            // if(!_requireMathcingOrder)return enumerable.ScrambledEquals(this);
            return enumerable.SequenceEqual(this);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            var hashCode = 0;
            foreach (var item in this)
            {
                hashCode ^= item?.GetHashCode() ?? 0;
            }

            return hashCode;
        }
    }
}
