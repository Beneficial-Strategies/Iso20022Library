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
    [KnownType(typeof(RateAndAmountFormat47Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat47Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat47Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat47Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.Rate),nameof(RateAndAmountFormat47Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.NotSpecifiedRate),nameof(RateAndAmountFormat47Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.Amount),nameof(RateAndAmountFormat47Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat47Choice.RateTypeAndRate),nameof(RateAndAmountFormat47Choice.RateTypeAndRate))]
    #endif
    [IsoId("_cteocZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat47Choice_
    #else
    public abstract partial class RateAndAmountFormat47Choice_
    #endif
    {
    }
}
