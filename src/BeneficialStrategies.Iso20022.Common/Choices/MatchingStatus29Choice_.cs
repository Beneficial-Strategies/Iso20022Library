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
    [KnownType(typeof(MatchingStatus29Choice.Matched))]
    [KnownType(typeof(MatchingStatus29Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus29Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus29Choice.Matched),nameof(MatchingStatus29Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus29Choice.Unmatched),nameof(MatchingStatus29Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus29Choice.Proprietary),nameof(MatchingStatus29Choice.Proprietary))]
    #endif
    [IsoId("_6BH3wZNLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus29Choice_
    #else
    public abstract partial class MatchingStatus29Choice_
    #endif
    {
    }
}
