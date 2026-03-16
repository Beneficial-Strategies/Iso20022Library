// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Price Format90Choice.
    /// </summary>
    [KnownType(typeof(PriceFormat90Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat90Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat90Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat90Choice.IndexPoints))]
    [KnownType(typeof(PriceFormat90Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat90Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat90Choice.AmountPrice),nameof(PriceFormat90Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat90Choice.AmountPricePerAmount),nameof(PriceFormat90Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat90Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat90Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat90Choice.IndexPoints),nameof(PriceFormat90Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat90Choice.NotSpecifiedPrice),nameof(PriceFormat90Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat90Choice.PercentagePrice),nameof(PriceFormat90Choice.PercentagePrice))]
    [IsoId("_l6XmzJt3Ee-wQIOX0djF2w")]
    [DisplayName("Price Format90Choice")]
    public abstract partial record PriceFormat90Choice_
    {
    }
}
