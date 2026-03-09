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
    /// Choice of format between a rate, an amount, index points or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat19Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat19Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat19Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat19Choice.IndexPoints))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.Rate),nameof(RateAndAmountFormat19Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.NotSpecifiedRate),nameof(RateAndAmountFormat19Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.Amount),nameof(RateAndAmountFormat19Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat19Choice.IndexPoints),nameof(RateAndAmountFormat19Choice.IndexPoints))]
    #endif
    [IsoId("_UiZ3KyXzEeO4bIO_HtGo9Q")]
    [DisplayName("Rate And Amount Format 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat19Choice_
    #else
    public abstract partial class RateAndAmountFormat19Choice_
    #endif
    {
    }
}
