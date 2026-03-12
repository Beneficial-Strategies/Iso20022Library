// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormatSD2Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormatSD2Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormatSD2Choice.NotSpecifiedPrice),nameof(PriceFormatSD2Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormatSD2Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormatSD2Choice.AmountPricePerFinancialInstrumentQuantity))]
    [IsoId("_siRLoaFWEeSK_vfd3NHBGg")]
    [DisplayName("Price Format SD 2 Choice")]
    public abstract partial record PriceFormatSD2Choice_
    {
    }
}
