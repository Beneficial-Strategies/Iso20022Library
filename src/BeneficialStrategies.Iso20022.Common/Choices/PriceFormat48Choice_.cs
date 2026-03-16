// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat48Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat48Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat48Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat48Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat48Choice.IndexPoints))]
    [JsonDerivedType(
        typeof(PriceFormat48Choice.PercentagePrice),
        nameof(PriceFormat48Choice.PercentagePrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat48Choice.AmountPrice),
        nameof(PriceFormat48Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat48Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat48Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat48Choice.AmountPricePerAmount),
        nameof(PriceFormat48Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat48Choice.IndexPoints),
        nameof(PriceFormat48Choice.IndexPoints)
    )]
    [IsoId("_puBHSUELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 48 Choice")]
    public abstract record PriceFormat48Choice_ { }
}
