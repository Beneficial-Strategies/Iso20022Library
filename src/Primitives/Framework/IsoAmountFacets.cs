// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;
using System.Globalization;

namespace BeneficialStrategies.Iso20022.Framework
{
    /// <summary>
    /// Checks an amount against the facets its <see cref="IsoAmountAttribute"/> declares. The limits are those of the ISO amount types:
    /// the value is not negative (zero is allowed), has at most <see cref="IsoAmountAttribute.TotalDigits"/> significant digits and at
    /// most <see cref="IsoAmountAttribute.FractionDigits"/> digits after the decimal point. As in the XSD, trailing zeros do not count
    /// (<c>1.50000000</c> has one fraction digit).
    /// </summary>
    public static class IsoAmountFacets
    {
        private static readonly ConcurrentDictionary<(Type Owner, string Property), IsoAmountAttribute?> Declared = new();

        // A decimal divided by this has its trailing zeros removed.
        private const decimal WithoutTrailingZeros = 1.000000000000000000000000000000m;

        /// <summary>
        /// Returns <paramref name="value"/> when it meets the facets of <paramref name="property"/> of <paramref name="owner"/>; this is
        /// what an amount record's <c>Amount</c> setter calls.
        /// </summary>
        /// <exception cref="Iso20022FormatException">Thrown when the value is negative or has too many digits.</exception>
        public static decimal Check(Type owner, string property, decimal value)
        {
            var facets = Declared.GetOrAdd((owner, property), key => key.Owner.GetProperty(key.Property)?.GetCustomAttributes(typeof(IsoAmountAttribute), false).FirstOrDefault() as IsoAmountAttribute);
            if (facets is not null && Violation(facets, value) is { } reason)
                throw new Iso20022FormatException(owner, value.ToString(CultureInfo.InvariantCulture), reason);
            return value;
        }

        /// <summary>What is wrong with <paramref name="value"/> for these facets, or <see langword="null"/> when nothing is.</summary>
        public static string? Violation(IsoAmountAttribute facets, decimal value)
        {
            if (value < 0m)
                return "not negative";
            var normalized = value / WithoutTrailingZeros;
            var scale = (normalized.GetBits3() >> 16) & 0x7F;
            if (scale > facets.FractionDigits)
                return $"at most {facets.FractionDigits} fraction digits";
            var integerDigits = Math.Truncate(normalized) == 0m ? 0 : Math.Truncate(normalized).ToString(CultureInfo.InvariantCulture).Length;
            if (integerDigits + scale > facets.TotalDigits)
                return $"at most {facets.TotalDigits} significant digits in total";
            return null;
        }

        private static int GetBits3(this decimal value) => decimal.GetBits(value)[3];
    }
}
