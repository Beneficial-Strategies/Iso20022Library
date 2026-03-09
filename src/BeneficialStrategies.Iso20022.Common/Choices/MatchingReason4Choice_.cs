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
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason4Choice.Reason))]
    [KnownType(typeof(MatchingReason4Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingReason4Choice.Reason),nameof(MatchingReason4Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason4Choice.NoSpecifiedReason),nameof(MatchingReason4Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_1Bk5i2XREeOWzsrIp2keDA")]
    [DisplayName("Matching Reason 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingReason4Choice_
    #else
    public abstract partial class MatchingReason4Choice_
    #endif
    {
    }
}
