// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format65Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat65Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat65Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat65Choice.RateTypeAndRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat65Choice.Amount),nameof(RateAndAmountFormat65Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat65Choice.Rate),nameof(RateAndAmountFormat65Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat65Choice.RateTypeAndRate),nameof(RateAndAmountFormat65Choice.RateTypeAndRate))]
    [IsoId("_kV6ww5t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format65Choice")]
    public abstract partial record RateAndAmountFormat65Choice_
    {
    }
}
