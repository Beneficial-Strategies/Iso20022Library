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
    [KnownType(typeof(RateAndAmountFormat52Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat52Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat52Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.Rate),nameof(RateAndAmountFormat52Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.Amount),nameof(RateAndAmountFormat52Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus),nameof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(RateAndAmountFormat52Choice.RateTypeAndRate),nameof(RateAndAmountFormat52Choice.RateTypeAndRate))]
    #endif
    [IsoId("_fFh9EJSoEeeh5JjedkaA_g")]
    [DisplayName("Rate And Amount Format 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat52Choice_
    #else
    public abstract partial class RateAndAmountFormat52Choice_
    #endif
    {
    }
}
