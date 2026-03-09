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
    [KnownType(typeof(RateAndAmountFormat21Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat21Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat21Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateAndAmountFormat21Choice.Rate),nameof(RateAndAmountFormat21Choice.Rate))]
    [JsonDerivedType(typeof(RateAndAmountFormat21Choice.Amount),nameof(RateAndAmountFormat21Choice.Amount))]
    [JsonDerivedType(typeof(RateAndAmountFormat21Choice.RateTypeAndRate),nameof(RateAndAmountFormat21Choice.RateTypeAndRate))]
    #endif
    [IsoId("_y_GIICeOEeOXAt_43VmZGw")]
    [DisplayName("Rate And Amount Format 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat21Choice_
    #else
    public abstract partial class RateAndAmountFormat21Choice_
    #endif
    {
    }
}
