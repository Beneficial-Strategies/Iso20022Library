// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format between a rate, an amount, index points or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat19Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat19Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat19Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat19Choice.IndexPoints))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.Rate),nameof(RateAndAmountFormat19Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.NotSpecifiedRate),nameof(RateAndAmountFormat19Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.Amount),nameof(RateAndAmountFormat19Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.IndexPoints),nameof(RateAndAmountFormat19Choice.IndexPoints))]
    [IsoId("_UiZ3KyXzEeO4bIO_HtGo9Q")]
    [DisplayName("Rate And Amount Format 19 Choice")]
    public abstract partial record RateAndAmountFormat19Choice_
    {
    }
}
