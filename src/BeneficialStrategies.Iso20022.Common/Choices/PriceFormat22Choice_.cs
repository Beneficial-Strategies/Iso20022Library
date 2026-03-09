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
    [KnownType(typeof(PriceFormat22Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat22Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat22Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat22Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat22Choice.AmountPricePerAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat22Choice.PercentagePrice),nameof(PriceFormat22Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat22Choice.AmountPrice),nameof(PriceFormat22Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat22Choice.NotSpecifiedPrice),nameof(PriceFormat22Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat22Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat22Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat22Choice.AmountPricePerAmount),nameof(PriceFormat22Choice.AmountPricePerAmount))]
    #endif
    [IsoId("_xvzyAOwNEd-sn-FiNtktcA")]
    [DisplayName("Price Format 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat22Choice_
    #else
    public abstract partial class PriceFormat22Choice_
    #endif
    {
    }
}
