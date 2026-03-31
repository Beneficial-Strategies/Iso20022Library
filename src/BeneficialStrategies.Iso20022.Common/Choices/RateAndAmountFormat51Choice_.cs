// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat51Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat51Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat51Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat51Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat51Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat51Choice.Rate),
        nameof(RateAndAmountFormat51Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat51Choice.Amount),
        nameof(RateAndAmountFormat51Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat51Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat51Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat51Choice.RateTypeAndAmountAndRateStatus),
        nameof(RateAndAmountFormat51Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat51Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat51Choice.RateTypeAndRate)
    )]
    [IsoId("_eN9Dj5SiEeeh5JjedkaA_g")]
    [DisplayName("Rate And Amount Format 51 Choice")]
    public abstract record RateAndAmountFormat51Choice_ { }
}
