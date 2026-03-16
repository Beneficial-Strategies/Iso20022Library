// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ranges of values in which an amount is considered valid or a specified amount value which has to be matched or unmatched to be valid.
    /// </summary>
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.FromAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.ToAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.FromToAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.EqualAmount))]
    [KnownType(typeof(ImpliedCurrencyAmountRangeChoice.NotEqualAmount))]
    [JsonDerivedType(
        typeof(ImpliedCurrencyAmountRangeChoice.FromAmount),
        nameof(ImpliedCurrencyAmountRangeChoice.FromAmount)
    )]
    [JsonDerivedType(
        typeof(ImpliedCurrencyAmountRangeChoice.ToAmount),
        nameof(ImpliedCurrencyAmountRangeChoice.ToAmount)
    )]
    [JsonDerivedType(
        typeof(ImpliedCurrencyAmountRangeChoice.FromToAmount),
        nameof(ImpliedCurrencyAmountRangeChoice.FromToAmount)
    )]
    [JsonDerivedType(
        typeof(ImpliedCurrencyAmountRangeChoice.EqualAmount),
        nameof(ImpliedCurrencyAmountRangeChoice.EqualAmount)
    )]
    [JsonDerivedType(
        typeof(ImpliedCurrencyAmountRangeChoice.NotEqualAmount),
        nameof(ImpliedCurrencyAmountRangeChoice.NotEqualAmount)
    )]
    [IsoId("_PU-ECtp-Ed-ak6NoX_4Aeg_847262836")]
    [DisplayName("Implied Currency Amount Range Choice")]
    public abstract record ImpliedCurrencyAmountRangeChoice_ { }
}
