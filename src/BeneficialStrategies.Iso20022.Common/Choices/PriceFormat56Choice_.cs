// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat56Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat56Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat56Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat56Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat56Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat56Choice.PercentagePrice),
        nameof(PriceFormat56Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat56Choice.AmountPrice),
        nameof(PriceFormat56Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat56Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat56Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat56Choice.AmountPricePerAmount),
        nameof(PriceFormat56Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat56Choice.IndexPoints),
        nameof(PriceFormat56Choice.IndexPoints)
    )]
    [IsoId("_ckDmwZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 56 Choice")]
    public abstract record PriceFormat56Choice_ { }
}
