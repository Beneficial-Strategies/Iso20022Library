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
    /// Choice between a rate or a rate type and rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat10Choice.Rate))]
    [KnownType(typeof(RateFormat10Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateFormat10Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat10Choice.Rate),nameof(RateFormat10Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat10Choice.NotSpecifiedRate),nameof(RateFormat10Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RateFormat10Choice.RateTypeAndRate),nameof(RateFormat10Choice.RateTypeAndRate))]
    #endif
    [IsoId("_CR-rCieJEeOXAt_43VmZGw")]
    [DisplayName("Rate Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat10Choice_
    #else
    public abstract partial class RateFormat10Choice_
    #endif
    {
    }
}
