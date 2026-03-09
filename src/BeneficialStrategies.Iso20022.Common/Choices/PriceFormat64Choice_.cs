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
    /// Choice between a percentage price or an amount price or an amount price per amount or an amount price per financial instrument quantity.
    /// </summary>
    [KnownType(typeof(PriceFormat64Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat64Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat64Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat64Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat64Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat64Choice.PercentagePrice),nameof(PriceFormat64Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat64Choice.AmountPrice),nameof(PriceFormat64Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat64Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat64Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat64Choice.AmountPricePerAmount),nameof(PriceFormat64Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat64Choice.IndexPoints),nameof(PriceFormat64Choice.IndexPoints))]
    #endif
    [IsoId("_HZc0eRuyEeyhRdHRjakS2w")]
    [DisplayName("Price Format 64 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat64Choice_
    #else
    public abstract partial class PriceFormat64Choice_
    #endif
    {
    }
}
