// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat46Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat46Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat46Choice.Amount))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat46Choice.Rate),
        nameof(RateAndAmountFormat46Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat46Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat46Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat46Choice.Amount),
        nameof(RateAndAmountFormat46Choice.Amount)
    )]
    [IsoId("_ctdar5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 46 Choice")]
    public abstract record RateAndAmountFormat46Choice_ { }
}
