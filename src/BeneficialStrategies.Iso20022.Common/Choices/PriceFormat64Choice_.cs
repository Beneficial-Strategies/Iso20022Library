// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat64Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat64Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat64Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat64Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat64Choice.IndexPoints))]
    [JsonDerivedType(typeof(PriceFormat64Choice.PercentagePrice),nameof(PriceFormat64Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat64Choice.AmountPrice),nameof(PriceFormat64Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat64Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat64Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat64Choice.AmountPricePerAmount),nameof(PriceFormat64Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat64Choice.IndexPoints),nameof(PriceFormat64Choice.IndexPoints))]
    [IsoId("_HZc0eRuyEeyhRdHRjakS2w")]
    [DisplayName("Price Format 64 Choice")]
    public abstract partial record PriceFormat64Choice_
    {
    }
}
