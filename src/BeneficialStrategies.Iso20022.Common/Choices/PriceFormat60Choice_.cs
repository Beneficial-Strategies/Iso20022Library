// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat60Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat60Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat60Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat60Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat60Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat60Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat60Choice.PercentagePrice),
        nameof(PriceFormat60Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat60Choice.AmountPrice),
        nameof(PriceFormat60Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat60Choice.NotSpecifiedPrice),
        nameof(PriceFormat60Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat60Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat60Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat60Choice.AmountPricePerAmount),
        nameof(PriceFormat60Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat60Choice.IndexPoints),
        nameof(PriceFormat60Choice.IndexPoints)
    )]
    [IsoId("_ctkvQZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 60 Choice")]
    public abstract record PriceFormat60Choice_ { }
}
