// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat33Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat33Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat33Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat33Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat33Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat33Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat33Choice.PercentagePrice),nameof(PriceFormat33Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat33Choice.AmountPrice),nameof(PriceFormat33Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat33Choice.NotSpecifiedPrice),nameof(PriceFormat33Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat33Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat33Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat33Choice.AmountPricePerAmount),nameof(PriceFormat33Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat33Choice.IndexPoints),nameof(PriceFormat33Choice.IndexPoints))]
    [IsoId("_r15aZSXtEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 33 Choice")]
    public abstract partial record PriceFormat33Choice_
    {
    }
}
