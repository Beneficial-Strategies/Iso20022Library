// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat49Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat49Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat49Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat49Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat49Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat49Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat49Choice.PercentagePrice),
        nameof(PriceFormat49Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat49Choice.AmountPrice),
        nameof(PriceFormat49Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat49Choice.NotSpecifiedPrice),
        nameof(PriceFormat49Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat49Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat49Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat49Choice.AmountPricePerAmount),
        nameof(PriceFormat49Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat49Choice.IndexPoints),
        nameof(PriceFormat49Choice.IndexPoints)
    )]
    [IsoId("_qHKnJUELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 49 Choice")]
    public abstract record PriceFormat49Choice_ { }
}
