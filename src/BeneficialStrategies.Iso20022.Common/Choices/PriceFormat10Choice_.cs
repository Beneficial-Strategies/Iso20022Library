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
    [KnownType(typeof(PriceFormat10Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat10Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat10Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat10Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat10Choice.AmountPricePerAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat10Choice.PercentagePrice),nameof(PriceFormat10Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat10Choice.AmountPrice),nameof(PriceFormat10Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat10Choice.NotSpecifiedPrice),nameof(PriceFormat10Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat10Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat10Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat10Choice.AmountPricePerAmount),nameof(PriceFormat10Choice.AmountPricePerAmount))]
    #endif
    [IsoId("_Q4z1Vdp-Ed-ak6NoX_4Aeg_-1792370853")]
    [DisplayName("Price Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat10Choice_
    #else
    public abstract partial class PriceFormat10Choice_
    #endif
    {
    }
}
