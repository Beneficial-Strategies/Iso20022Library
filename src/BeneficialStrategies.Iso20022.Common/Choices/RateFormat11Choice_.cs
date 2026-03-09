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
    [KnownType(typeof(RateFormat11Choice.Rate))]
    [KnownType(typeof(RateFormat11Choice.RateTypeAndRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat11Choice.Rate),nameof(RateFormat11Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat11Choice.RateTypeAndRate),nameof(RateFormat11Choice.RateTypeAndRate))]
    #endif
    [IsoId("_QLKPGyeOEeOXAt_43VmZGw")]
    [DisplayName("Rate Format 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat11Choice_
    #else
    public abstract partial class RateFormat11Choice_
    #endif
    {
    }
}
