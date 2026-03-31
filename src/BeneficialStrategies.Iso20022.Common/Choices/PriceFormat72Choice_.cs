// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format72Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat72Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat72Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat72Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat72Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat72Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat72Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat72Choice.AmountPrice),
        nameof(PriceFormat72Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat72Choice.AmountPricePerAmount),
        nameof(PriceFormat72Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat72Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat72Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat72Choice.IndexPoints),
        nameof(PriceFormat72Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat72Choice.NotSpecifiedPrice),
        nameof(PriceFormat72Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat72Choice.PercentagePrice),
        nameof(PriceFormat72Choice.PercentagePrice)
    )]
    [IsoId("_CeeRaYV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Price Format72Choice")]
    public abstract record PriceFormat72Choice_ { }
}
