// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat32Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat32Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat32Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat32Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat32Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat32Choice.PercentagePrice),
        nameof(PriceFormat32Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat32Choice.AmountPrice),
        nameof(PriceFormat32Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat32Choice.NotSpecifiedPrice),
        nameof(PriceFormat32Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat32Choice.AmountPricePerAmount),
        nameof(PriceFormat32Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat32Choice.IndexPoints),
        nameof(PriceFormat32Choice.IndexPoints)
    )]
    [IsoId("_4vHhsSXoEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 32 Choice")]
    public abstract record PriceFormat32Choice_ { }
}
