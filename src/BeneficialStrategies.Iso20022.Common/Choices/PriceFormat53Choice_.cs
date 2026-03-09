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
    [KnownType(typeof(PriceFormat53Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat53Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat53Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat53Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat53Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat53Choice.PercentagePrice),nameof(PriceFormat53Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat53Choice.AmountPrice),nameof(PriceFormat53Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat53Choice.NotSpecifiedPrice),nameof(PriceFormat53Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat53Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat53Choice.AmountPricePerAmount),nameof(PriceFormat53Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat53Choice.IndexPoints),nameof(PriceFormat53Choice.IndexPoints))]
    #endif
    [IsoId("_che0cZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 53 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat53Choice_
    #else
    public abstract partial class PriceFormat53Choice_
    #endif
    {
    }
}
