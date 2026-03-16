// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format70Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat70Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat70Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat70Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat70Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat70Choice.Amount),
        nameof(RateAndAmountFormat70Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat70Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat70Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat70Choice.Rate),
        nameof(RateAndAmountFormat70Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat70Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat70Choice.RateTypeAndRate)
    )]
    [IsoId("_l6T9CZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format70Choice")]
    public abstract record RateAndAmountFormat70Choice_ { }
}
