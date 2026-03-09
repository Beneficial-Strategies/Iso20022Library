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
    [KnownType(typeof(PriceFormat34Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat34Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat34Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat34Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat34Choice.PercentagePrice),nameof(PriceFormat34Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat34Choice.AmountPrice),nameof(PriceFormat34Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat34Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat34Choice.AmountPricePerAmount),nameof(PriceFormat34Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat34Choice.IndexPoints),nameof(PriceFormat34Choice.IndexPoints))]
    #endif
    [IsoId("_mVizRyXxEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat34Choice_
    #else
    public abstract partial class PriceFormat34Choice_
    #endif
    {
    }
}
