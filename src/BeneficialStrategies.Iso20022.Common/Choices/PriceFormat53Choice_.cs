// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat53Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat53Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat53Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat53Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat53Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat53Choice.PercentagePrice),
        nameof(PriceFormat53Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat53Choice.AmountPrice),
        nameof(PriceFormat53Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat53Choice.NotSpecifiedPrice),
        nameof(PriceFormat53Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat53Choice.AmountPricePerAmount),
        nameof(PriceFormat53Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat53Choice.IndexPoints),
        nameof(PriceFormat53Choice.IndexPoints)
    )]
    [IsoId("_che0cZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 53 Choice")]
    public abstract record PriceFormat53Choice_ { }
}
