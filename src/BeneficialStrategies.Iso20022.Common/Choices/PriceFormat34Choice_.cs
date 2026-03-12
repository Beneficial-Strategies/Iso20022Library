// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat34Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat34Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat34Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat34Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat34Choice.PercentagePrice),nameof(PriceFormat34Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat34Choice.AmountPrice),nameof(PriceFormat34Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat34Choice.AmountPricePerAmount),nameof(PriceFormat34Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat34Choice.IndexPoints),nameof(PriceFormat34Choice.IndexPoints))]
    [IsoId("_mVizRyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 34 Choice")]
    public abstract partial record PriceFormat34Choice_
    {
    }
}
