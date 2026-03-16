// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format76Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat76Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat76Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat76Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat76Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat76Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat76Choice.AmountPrice),
        nameof(PriceFormat76Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat76Choice.AmountPricePerAmount),
        nameof(PriceFormat76Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat76Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat76Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat76Choice.IndexPoints),
        nameof(PriceFormat76Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat76Choice.PercentagePrice),
        nameof(PriceFormat76Choice.PercentagePrice)
    )]
    [IsoId("_DGWwsYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format76Choice")]
    public abstract record PriceFormat76Choice_ { }
}
