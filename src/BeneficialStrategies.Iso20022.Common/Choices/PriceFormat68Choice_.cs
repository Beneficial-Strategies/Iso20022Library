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
    [KnownType(typeof(PriceFormat68Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat68Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat68Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat68Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat68Choice.PercentagePrice),nameof(PriceFormat68Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat68Choice.AmountPrice),nameof(PriceFormat68Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat68Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat68Choice.AmountPricePerAmount),nameof(PriceFormat68Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat68Choice.IndexPoints),nameof(PriceFormat68Choice.IndexPoints))]
    #endif
    [IsoId("_plY1dTi7Eeydid5dcNPKvg")]
    [DisplayName("Price Format 68 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat68Choice_
    #else
    public abstract partial class PriceFormat68Choice_
    #endif
    {
    }
}
