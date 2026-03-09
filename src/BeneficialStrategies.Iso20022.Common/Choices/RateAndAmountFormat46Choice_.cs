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
    /// Choice of format between a rate, an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat46Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat46Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat46Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat46Choice.Rate),nameof(RateAndAmountFormat46Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat46Choice.NotSpecifiedRate),nameof(RateAndAmountFormat46Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat46Choice.Amount),nameof(RateAndAmountFormat46Choice.Amount))]
    #endif
    [IsoId("_ctdar5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat46Choice_
    #else
    public abstract partial class RateAndAmountFormat46Choice_
    #endif
    {
    }
}
