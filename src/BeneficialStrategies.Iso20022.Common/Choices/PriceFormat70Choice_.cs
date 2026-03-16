// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat70Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat70Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat70Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat70Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat70Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat70Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat70Choice.PercentagePrice),
        nameof(PriceFormat70Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat70Choice.AmountPrice),
        nameof(PriceFormat70Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat70Choice.NotSpecifiedPrice),
        nameof(PriceFormat70Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat70Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat70Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat70Choice.AmountPricePerAmount),
        nameof(PriceFormat70Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat70Choice.IndexPoints),
        nameof(PriceFormat70Choice.IndexPoints)
    )]
    [IsoId("_p4jBXTi7Eeydid5dcNPKvg")]
    [DisplayName("Price Format 70 Choice")]
    public abstract record PriceFormat70Choice_ { }
}
