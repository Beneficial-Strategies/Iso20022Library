// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format84Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat84Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat84Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat84Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat84Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat84Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat84Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat84Choice.AmountPrice),nameof(PriceFormat84Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat84Choice.AmountPricePerAmount),nameof(PriceFormat84Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat84Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat84Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat84Choice.IndexPoints),nameof(PriceFormat84Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat84Choice.NotSpecifiedPrice),nameof(PriceFormat84Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat84Choice.PercentagePrice),nameof(PriceFormat84Choice.PercentagePrice))]
    [IsoId("_kV6x75t3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format84Choice")]
    public abstract partial record PriceFormat84Choice_
    {
    }
}
