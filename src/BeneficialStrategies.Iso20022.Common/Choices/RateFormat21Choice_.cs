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
    [KnownType(typeof(RateFormat21Choice.Rate))]
    [KnownType(typeof(RateFormat21Choice.Amount))]
    [KnownType(typeof(RateFormat21Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat21Choice.Rate),nameof(RateFormat21Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat21Choice.Amount),nameof(RateFormat21Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat21Choice.NotSpecifiedRate),nameof(RateFormat21Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_ctoZkZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate Format 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat21Choice_
    #else
    public abstract partial class RateFormat21Choice_
    #endif
    {
    }
}
