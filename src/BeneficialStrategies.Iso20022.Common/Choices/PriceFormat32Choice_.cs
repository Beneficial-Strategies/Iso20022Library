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
    [KnownType(typeof(PriceFormat32Choice.PercentagePrice))]
    [KnownType(typeof(PriceFormat32Choice.AmountPrice))]
    [KnownType(typeof(PriceFormat32Choice.NotSpecifiedPrice))]
    [KnownType(typeof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity))]
    [KnownType(typeof(PriceFormat32Choice.AmountPricePerAmount))]
    [KnownType(typeof(PriceFormat32Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PriceFormat32Choice.PercentagePrice),nameof(PriceFormat32Choice.PercentagePrice))]
    [JsonDerivedType(typeof(PriceFormat32Choice.AmountPrice),nameof(PriceFormat32Choice.AmountPrice))]
    [JsonDerivedType(typeof(PriceFormat32Choice.NotSpecifiedPrice),nameof(PriceFormat32Choice.NotSpecifiedPrice))]
    [JsonDerivedType(typeof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity),nameof(PriceFormat32Choice.AmountPricePerFinancialInstrumentQuantity))]
    [JsonDerivedType(typeof(PriceFormat32Choice.AmountPricePerAmount),nameof(PriceFormat32Choice.AmountPricePerAmount))]
    [JsonDerivedType(typeof(PriceFormat32Choice.IndexPoints),nameof(PriceFormat32Choice.IndexPoints))]
    #endif
    [IsoId("_4vHhsSXoEeO4bIO_HtGo9Q")]
    [DisplayName("Price Format 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PriceFormat32Choice_
    #else
    public abstract partial class PriceFormat32Choice_
    #endif
    {
    }
}
