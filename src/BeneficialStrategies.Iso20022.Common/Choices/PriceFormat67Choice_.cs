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
    [KnownType(typeof(PriceFormat67Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat67Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat67Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat67Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat67Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat67Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat67Choice.PercentagePrice),nameof(PriceFormat67Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat67Choice.AmountPrice),nameof(PriceFormat67Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat67Choice.NotSpecifiedPrice),nameof(PriceFormat67Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat67Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat67Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat67Choice.AmountPricePerAmount),nameof(PriceFormat67Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat67Choice.IndexPoints),nameof(PriceFormat67Choice.IndexPoints))]
    #endif
    [IsoId("_pi0C_ji7Eeydid5dcNPKvg")]
    [DisplayName("Price Format 67 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat67Choice_
    #else
    public abstract partial class PriceFormat67Choice_
    #endif
    {
    }
}
