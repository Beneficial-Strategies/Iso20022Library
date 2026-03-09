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
    [KnownType(typeof(PriceFormat66Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat66Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat66Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat66Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat66Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat66Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat66Choice.PercentagePrice),nameof(PriceFormat66Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat66Choice.AmountPrice),nameof(PriceFormat66Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat66Choice.NotSpecifiedPrice),nameof(PriceFormat66Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat66Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat66Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat66Choice.AmountPricePerAmount),nameof(PriceFormat66Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat66Choice.IndexPoints),nameof(PriceFormat66Choice.IndexPoints))]
    #endif
    [IsoId("_O9l7ZRuyEeyhRdHRjakS2w")]
    [DisplayName("Price Format 66 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat66Choice_
    #else
    public abstract partial class PriceFormat66Choice_
    #endif
    {
    }
}
