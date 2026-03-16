// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat68Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat68Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat68Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat68Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat68Choice.PercentagePrice),
        nameof(PriceFormat68Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat68Choice.AmountPrice),
        nameof(PriceFormat68Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat68Choice.AmountPricePerAmount),
        nameof(PriceFormat68Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat68Choice.IndexPoints),
        nameof(PriceFormat68Choice.IndexPoints)
    )]
    [IsoId("_plY1dTi7Eeydid5dcNPKvg")]
    [DisplayName("Price Format 68 Choice")]
    public abstract record PriceFormat68Choice_ { }
}
