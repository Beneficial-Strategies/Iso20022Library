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
    [KnownType(typeof(MatchingReason6Choice.Reason))]
    [KnownType(typeof(MatchingReason6Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingReason6Choice.Reason),nameof(MatchingReason6Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason6Choice.NoSpecifiedReason),nameof(MatchingReason6Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_gV_p0Qd4Ee2fOITqoTnSLQ")]
    [DisplayName("Matching Reason 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingReason6Choice_
    #else
    public abstract partial class MatchingReason6Choice_
    #endif
    {
    }
}
