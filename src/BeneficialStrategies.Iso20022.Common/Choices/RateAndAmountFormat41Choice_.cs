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
    [KnownType(typeof(RateAndAmountFormat41Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat41Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat41Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat41Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat41Choice.Rate),nameof(RateAndAmountFormat41Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat41Choice.NotSpecifiedRate),nameof(RateAndAmountFormat41Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat41Choice.Amount),nameof(RateAndAmountFormat41Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat41Choice.RateTypeAndRate),nameof(RateAndAmountFormat41Choice.RateTypeAndRate))]
    #endif
    [IsoId("__1-kPUEIEeWVgfuHGaKtRQ")]
    [DisplayName("Rate And Amount Format 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat41Choice_
    #else
    public abstract partial class RateAndAmountFormat41Choice_
    #endif
    {
    }
}
