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
    [KnownType(typeof(MatchingStatus34Choice.Matched))]
    [KnownType(typeof(MatchingStatus34Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus34Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus34Choice.Matched),nameof(MatchingStatus34Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus34Choice.Unmatched),nameof(MatchingStatus34Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus34Choice.Proprietary),nameof(MatchingStatus34Choice.Proprietary))]
    #endif
    [IsoId("_yZ5IBxUHEeuZw7VHHgrHLg")]
    [DisplayName("Matching Status 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus34Choice_
    #else
    public abstract partial class MatchingStatus34Choice_
    #endif
    {
    }
}
