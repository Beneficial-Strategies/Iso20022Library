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
    [KnownType(typeof(PriceFormat21Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat21Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat21Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat21Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat21Choice.AmountPricePerAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat21Choice.PercentagePrice),nameof(PriceFormat21Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat21Choice.AmountPrice),nameof(PriceFormat21Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat21Choice.NotSpecifiedPrice),nameof(PriceFormat21Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat21Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat21Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat21Choice.AmountPricePerAmount),nameof(PriceFormat21Choice.AmountPricePerAmount))]
    #endif
    [IsoId("_yBTOXeEPEd-1Ktb5rVaajw")]
    [DisplayName("Price Format 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat21Choice_
    #else
    public abstract partial class PriceFormat21Choice_
    #endif
    {
    }
}
