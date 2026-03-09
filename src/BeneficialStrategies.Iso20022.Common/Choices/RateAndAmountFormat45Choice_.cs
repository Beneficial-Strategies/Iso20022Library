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
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat45Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat45Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat45Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat45Choice.Rate),nameof(RateAndAmountFormat45Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat45Choice.Amount),nameof(RateAndAmountFormat45Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat45Choice.RateTypeAndRate),nameof(RateAndAmountFormat45Choice.RateTypeAndRate))]
    #endif
    [IsoId("_cj-HW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat45Choice_
    #else
    public abstract partial class RateAndAmountFormat45Choice_
    #endif
    {
    }
}
