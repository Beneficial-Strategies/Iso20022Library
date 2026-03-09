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
    /// Choice of format for the matching status.
    /// </summary>
    [KnownType(typeof(MatchingStatus26Choice.Matched))]
    [KnownType(typeof(MatchingStatus26Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus26Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus26Choice.Matched),nameof(MatchingStatus26Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus26Choice.Unmatched),nameof(MatchingStatus26Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus26Choice.Proprietary),nameof(MatchingStatus26Choice.Proprietary))]
    #endif
    [IsoId("_04bG4Tp4EeWVrPy0StzzSg")]
    [DisplayName("Matching Status 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus26Choice_
    #else
    public abstract partial class MatchingStatus26Choice_
    #endif
    {
    }
}
