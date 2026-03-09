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
    [KnownType(typeof(PriceFormat47Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat47Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat47Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat47Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat47Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat47Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat47Choice.PercentagePrice),nameof(PriceFormat47Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat47Choice.AmountPrice),nameof(PriceFormat47Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat47Choice.NotSpecifiedPrice),nameof(PriceFormat47Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat47Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat47Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat47Choice.AmountPricePerAmount),nameof(PriceFormat47Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat47Choice.IndexPoints),nameof(PriceFormat47Choice.IndexPoints))]
    #endif
    [IsoId("_pIFIkUELEeWVgfuHGaKtRQ")]
    [DisplayName("Price Format 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat47Choice_
    #else
    public abstract partial class PriceFormat47Choice_
    #endif
    {
    }
}
