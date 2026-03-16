// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format77Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat77Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat77Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat77Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat77Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat77Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat77Choice.Amount),
        nameof(RateAndAmountFormat77Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat77Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat77Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat77Choice.Rate),
        nameof(RateAndAmountFormat77Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat77Choice.RateTypeAndAmountAndRateStatus),
        nameof(RateAndAmountFormat77Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat77Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat77Choice.RateTypeAndRate)
    )]
    [IsoId("_nLnzWZt3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format77Choice")]
    public abstract record RateAndAmountFormat77Choice_ { }
}
