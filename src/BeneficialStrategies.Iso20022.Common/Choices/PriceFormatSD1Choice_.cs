// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormatSD1Choice.AmountPrice))]
    [KnownType(typeof(PriceFormatSD1Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormatSD1Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(
        typeof(PriceFormatSD1Choice.AmountPrice),
        nameof(PriceFormatSD1Choice.AmountPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormatSD1Choice.NotSpecifiedPrice),
        nameof(PriceFormatSD1Choice.NotSpecifiedPrice)
    )]
    [JsonDerivedType(
        typeof(PriceFormatSD1Choice.AmountPricePerFinancialInstrumentQuantity),
        nameof(PriceFormatSD1Choice.AmountPricePerFinancialInstrumentQuantity)
    )]
    [IsoId("_1lQOQTL3EeKU9IrkkToqcw_1771719076")]
    [DisplayName("Price Format SD 1 Choice")]
    public abstract record PriceFormatSD1Choice_ { }
}
