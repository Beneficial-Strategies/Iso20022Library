// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a percentage price or an amount price or an unspecified price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormatSD1Choice.AmountPrice))]
    [KnownType(typeof(PriceFormatSD1Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormatSD1Choice.AmountPricePerFinancialInstrumentQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormatSD1Choice.AmountPrice),nameof(PriceFormatSD1Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormatSD1Choice.NotSpecifiedPrice),nameof(PriceFormatSD1Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormatSD1Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormatSD1Choice.AmountPricePerFinancialInstrumentQuantity))]
    #endif
    [IsoId("_1lQOQTL3EeKU9IrkkToqcw_1771719076")]
    [DisplayName("Price Format SD 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormatSD1Choice_
    #else
    public abstract partial class PriceFormatSD1Choice_
    #endif
    {
    }
}
