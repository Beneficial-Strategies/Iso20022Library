// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount, index points or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat50Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat50Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat50Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat50Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat50Choice.Rate),
        nameof(RateAndAmountFormat50Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat50Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat50Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat50Choice.Amount),
        nameof(RateAndAmountFormat50Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat50Choice.IndexPoints),
        nameof(RateAndAmountFormat50Choice.IndexPoints)
    )]
    [IsoId("_c5SQhZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 50 Choice")]
    public abstract record RateAndAmountFormat50Choice_ { }
}
