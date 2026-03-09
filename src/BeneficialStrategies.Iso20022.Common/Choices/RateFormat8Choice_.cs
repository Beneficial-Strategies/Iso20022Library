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
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat8Choice.Rate))]
    [KnownType(typeof(RateFormat8Choice.Amount))]
    [KnownType(typeof(RateFormat8Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat8Choice.Rate),nameof(RateFormat8Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat8Choice.Amount),nameof(RateFormat8Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat8Choice.NotSpecifiedRate),nameof(RateFormat8Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_VA1AzhLtEeKJ5uSjVyVvug")]
    [DisplayName("Rate Format 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat8Choice_
    #else
    public abstract partial class RateFormat8Choice_
    #endif
    {
    }
}
