// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormatSD3Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormatSD3Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormatSD3Choice.NotSpecifiedPrice),nameof(PriceFormatSD3Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormatSD3Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormatSD3Choice.AmountPricePerFinancialInstrumentQuantity))]
    [IsoId("_VWv1UcSREeeRJJtE9TSlkw")]
    [DisplayName("Price Format SD 3 Choice")]
    public abstract partial record PriceFormatSD3Choice_
    {
    }
}
