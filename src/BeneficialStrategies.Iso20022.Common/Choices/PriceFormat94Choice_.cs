// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format94Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat94Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat94Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat94Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat94Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat94Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat94Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat94Choice.AmountPrice),
        nameof(PriceFormat94Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat94Choice.AmountPricePerAmount),
        nameof(PriceFormat94Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat94Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat94Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat94Choice.IndexPoints),
        nameof(PriceFormat94Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat94Choice.NotSpecifiedPrice),
        nameof(PriceFormat94Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat94Choice.PercentagePrice),
        nameof(PriceFormat94Choice.PercentagePrice)
    )]
    [IsoId("_nLmjw5t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format94Choice")]
    public abstract record PriceFormat94Choice_ { }
}
