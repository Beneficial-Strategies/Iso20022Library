// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format87Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat87Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat87Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat87Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat87Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat87Choice.PercentagePrice))]
    [JsonDerivedType(
        typeof(PriceFormat87Choice.AmountPrice),
        nameof(PriceFormat87Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormat87Choice.AmountPricePerAmount),
        nameof(PriceFormat87Choice.AmountPricePerAmount)
    )]
    [JsonDerivedType(
        typeof(PriceFormat87Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormat87Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [JsonDerivedType(
        typeof(PriceFormat87Choice.IndexPoints),
        nameof(PriceFormat87Choice.IndexPoints)
    )]
    [JsonDerivedType(
        typeof(PriceFormat87Choice.PercentagePrice),
        nameof(PriceFormat87Choice.PercentagePrice)
    )]
    [IsoId("_kv70U5t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format87Choice")]
    public abstract record PriceFormat87Choice_ { }
}
