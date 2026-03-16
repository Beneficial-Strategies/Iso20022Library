// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format68Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat68Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat68Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat68Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat68Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat68Choice.Amount),
        nameof(RateAndAmountFormat68Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat68Choice.Rate),
        nameof(RateAndAmountFormat68Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat68Choice.RateTypeAndAmountAndRateStatus),
        nameof(RateAndAmountFormat68Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat68Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat68Choice.RateTypeAndRate)
    )]
    [IsoId("_kwAET5t3Ee-wQIOX0djF2w")]
    [DisplayName("Rate And Amount Format68Choice")]
    public abstract record RateAndAmountFormat68Choice_ { }
}
