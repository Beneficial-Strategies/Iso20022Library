// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat41Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat41Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat41Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat41Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat41Choice.Rate),
        nameof(RateAndAmountFormat41Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat41Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat41Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat41Choice.Amount),
        nameof(RateAndAmountFormat41Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat41Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat41Choice.RateTypeAndRate)
    )]
    [IsoId("__1-kPUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 41 Choice")]
    public abstract record RateAndAmountFormat41Choice_ { }
}
