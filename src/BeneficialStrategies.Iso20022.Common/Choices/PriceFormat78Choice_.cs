// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format78Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat78Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat78Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat78Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat78Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat78Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat78Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat78Choice.AmountPrice),
        nameof(PriceFormat78Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat78Choice.AmountPricePerAmount),
        nameof(PriceFormat78Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat78Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat78Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat78Choice.IndexPoints),
        nameof(PriceFormat78Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat78Choice.NotSpecifiedPrice),
        nameof(PriceFormat78Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat78Choice.PercentagePrice),
        nameof(PriceFormat78Choice.PercentagePrice)
    )]
    [IsoId("_D-mnc4V6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format78Choice")]
    public abstract record PriceFormat78Choice_ { }
}
