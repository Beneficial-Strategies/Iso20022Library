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
    [KnownType(typeof(PriceFormat7Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat7Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat7Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat7Choice.AmountPricePerAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat7Choice.PercentagePrice),nameof(PriceFormat7Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat7Choice.AmountPrice),nameof(PriceFormat7Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat7Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat7Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat7Choice.AmountPricePerAmount),nameof(PriceFormat7Choice.AmountPricePerAmount))]
    #endif
    [IsoId("_Q4qEUNp-Ed-ak6NoX_4Aeg_354313475")]
    [DisplayName("Price Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat7Choice_
    #else
    public abstract partial class PriceFormat7Choice_
    #endif
    {
    }
}
