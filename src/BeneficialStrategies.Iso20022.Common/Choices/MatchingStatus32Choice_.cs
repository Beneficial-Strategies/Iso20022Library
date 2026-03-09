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
    [KnownType(typeof(MatchingStatus32Choice.Matched))]
    [KnownType(typeof(MatchingStatus32Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus32Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus32Choice.Matched),nameof(MatchingStatus32Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus32Choice.Unmatched),nameof(MatchingStatus32Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus32Choice.Proprietary),nameof(MatchingStatus32Choice.Proprietary))]
    #endif
    [IsoId("_6d8XS5NLEeWGlc8L7oPDIg")]
    [DisplayName("Matching Status 32 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus32Choice_
    #else
    public abstract partial class MatchingStatus32Choice_
    #endif
    {
    }
}
