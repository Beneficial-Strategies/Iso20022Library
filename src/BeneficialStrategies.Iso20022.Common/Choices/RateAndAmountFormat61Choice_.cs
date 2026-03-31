// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Rate And Amount Format61Choice.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat61Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat61Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat61Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat61Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat61Choice.RateTypeAndRate))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat61Choice.Amount),
        nameof(RateAndAmountFormat61Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat61Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat61Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat61Choice.Rate),
        nameof(RateAndAmountFormat61Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat61Choice.RateTypeAndAmountAndRateStatus),
        nameof(RateAndAmountFormat61Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat61Choice.RateTypeAndRate),
        nameof(RateAndAmountFormat61Choice.RateTypeAndRate)
    )]
    [IsoId("_JShikYV7Ee-oeNhl-Tk6YQ")]
    [DisplayName("Rate And Amount Format61Choice")]
    public abstract record RateAndAmountFormat61Choice_ { }
}
