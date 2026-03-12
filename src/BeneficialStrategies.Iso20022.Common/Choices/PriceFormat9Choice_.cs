// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat9Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat9Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat9Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat9Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat9Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat9Choice.PercentagePrice),nameof(PriceFormat9Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat9Choice.AmountPrice),nameof(PriceFormat9Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat9Choice.NotSpecifiedPrice),nameof(PriceFormat9Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat9Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat9Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat9Choice.AmountPricePerAmount),nameof(PriceFormat9Choice.AmountPricePerAmount))]
    [IsoId("_Q2IUz9p-Ed-ak6NoX_4Aeg_856668219")]
    [DisplayName("Price Format 9 Choice")]
    public abstract partial record PriceFormat9Choice_
    {
    }
}
