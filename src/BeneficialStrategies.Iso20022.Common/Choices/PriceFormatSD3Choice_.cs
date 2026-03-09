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
    [KnownType(typeof(PriceFormatSD3Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormatSD3Choice.AmountPricePerFinancialInstrumentQuantity))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormatSD3Choice.NotSpecifiedPrice),nameof(PriceFormatSD3Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormatSD3Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormatSD3Choice.AmountPricePerFinancialInstrumentQuantity))]
    #endif
    [IsoId("_VWv1UcSREeeRJJtE9TSlkw")]
    [DisplayName("Price Format SD 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormatSD3Choice_
    #else
    public abstract partial class PriceFormatSD3Choice_
    #endif
    {
    }
}
