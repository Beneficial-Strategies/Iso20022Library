// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format76Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat76Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat76Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat76Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat76Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat76Choice.Amount),
        nameof(RateAndAmountFormat76Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat76Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat76Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat76Choice.Rate),
        nameof(RateAndAmountFormat76Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat76Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat76Choice.RateTypeAndRate)
    )]
    [IsoId("_nLi6m5t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format76Choice")]
    public abstract record RateAndAmountFormat76Choice_ { }
}
