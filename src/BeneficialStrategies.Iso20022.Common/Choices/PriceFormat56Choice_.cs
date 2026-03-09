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
    [KnownType(typeof(PriceFormat56Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat56Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat56Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat56Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat56Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat56Choice.PercentagePrice),nameof(PriceFormat56Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat56Choice.AmountPrice),nameof(PriceFormat56Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat56Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat56Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat56Choice.AmountPricePerAmount),nameof(PriceFormat56Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat56Choice.IndexPoints),nameof(PriceFormat56Choice.IndexPoints))]
    #endif
    [IsoId("_ckDmwZKQEeWHWpTQn1FFVg")]
    [DisplayName("Price Format 56 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat56Choice_
    #else
    public abstract partial class PriceFormat56Choice_
    #endif
    {
    }
}
