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
    [KnownType(typeof(PriceFormat65Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat65Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat65Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat65Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat65Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat65Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat65Choice.PercentagePrice),nameof(PriceFormat65Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat65Choice.AmountPrice),nameof(PriceFormat65Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat65Choice.NotSpecifiedPrice),nameof(PriceFormat65Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat65Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat65Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat65Choice.AmountPricePerAmount),nameof(PriceFormat65Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat65Choice.IndexPoints),nameof(PriceFormat65Choice.IndexPoints))]
    #endif
    [IsoId("_L_wROxuyEeyhRdHRjakS2w")]
    [DisplayName("Price Format 65 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat65Choice_
    #else
    public abstract partial class PriceFormat65Choice_
    #endif
    {
    }
}
