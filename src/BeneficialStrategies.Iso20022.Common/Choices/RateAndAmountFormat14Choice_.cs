// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat14Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat14Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat14Choice.Amount))]
    [JsonDerivedType(
        typeof(RateAndAmountFormat14Choice.Rate),
        nameof(RateAndAmountFormat14Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat14Choice.NotSpecifiedRate),
        nameof(RateAndAmountFormat14Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RateAndAmountFormat14Choice.Amount),
        nameof(RateAndAmountFormat14Choice.Amount)
    )]
    [IsoId("_po6BweGYEd-1Ktb5rVaajw")]
    [DisplayName("Rate And Amount Format 14 Choice")]
    public abstract record RateAndAmountFormat14Choice_ { }
}
