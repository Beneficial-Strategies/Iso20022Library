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
    [KnownType(typeof(PriceFormat20Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat20Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat20Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat20Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat20Choice.AmountPricePerAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat20Choice.PercentagePrice),nameof(PriceFormat20Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat20Choice.AmountPrice),nameof(PriceFormat20Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat20Choice.NotSpecifiedPrice),nameof(PriceFormat20Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat20Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat20Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat20Choice.AmountPricePerAmount),nameof(PriceFormat20Choice.AmountPricePerAmount))]
    #endif
    [IsoId("_sJ7aAeEJEd-udr336SN7mQ")]
    [DisplayName("Price Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat20Choice_
    #else
    public abstract partial class PriceFormat20Choice_
    #endif
    {
    }
}
