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
    [KnownType(typeof(PriceFormat49Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat49Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat49Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat49Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat49Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat49Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat49Choice.PercentagePrice),nameof(PriceFormat49Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat49Choice.AmountPrice),nameof(PriceFormat49Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat49Choice.NotSpecifiedPrice),nameof(PriceFormat49Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat49Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat49Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat49Choice.AmountPricePerAmount),nameof(PriceFormat49Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat49Choice.IndexPoints),nameof(PriceFormat49Choice.IndexPoints))]
    #endif
    [IsoId("_qHKnJUELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 49 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat49Choice_
    #else
    public abstract partial class PriceFormat49Choice_
    #endif
    {
    }
}
