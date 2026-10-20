// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Framework
{
    /// <summary>
    /// The facets of the decimal that an ISO amount type (<c>ActiveCurrencyAndAmount</c> and the others) restricts its value to: not
    /// negative, at most <see cref="TotalDigits"/> significant digits in all, at most <see cref="FractionDigits"/> after the decimal point.
    /// Put on the <c>Amount</c> member of an amount record and of a choice variant that replicates one, and on the interface member.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class IsoAmountAttribute : System.Attribute
    {
        /// <summary>The most significant digits the amount may have in all (the XSD <c>totalDigits</c>).</summary>
        public int TotalDigits { get; }

        /// <summary>The most digits the amount may have after the decimal point (the XSD <c>fractionDigits</c>).</summary>
        public int FractionDigits { get; }

        /// <summary>Constructs the attribute with the limits of the amount type.</summary>
        public IsoAmountAttribute(int totalDigits, int fractionDigits)
        {
            TotalDigits = totalDigits;
            FractionDigits = fractionDigits;
        }
    }
}
