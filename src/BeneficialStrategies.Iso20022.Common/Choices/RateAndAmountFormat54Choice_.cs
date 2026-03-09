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
    /// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat54Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat54Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat54Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.Rate),nameof(RateAndAmountFormat54Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.Amount),nameof(RateAndAmountFormat54Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat54Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat54Choice.RateTypeAndRate),nameof(RateAndAmountFormat54Choice.RateTypeAndRate))]
    #endif
    [IsoId("_TTFAsdEDEeetfps_dpxRmg")]
    [DisplayName("Rate And Amount Format 54 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat54Choice_
    #else
    public abstract partial class RateAndAmountFormat54Choice_
    #endif
    {
    }
}
