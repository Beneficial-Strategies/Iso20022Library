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
    /// Provides the matching status of the instruction.
    /// </summary>
    [KnownType(typeof(MatchingStatus33Choice.Matched))]
    [KnownType(typeof(MatchingStatus33Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus33Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus33Choice.Matched),nameof(MatchingStatus33Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus33Choice.Unmatched),nameof(MatchingStatus33Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus33Choice.Proprietary),nameof(MatchingStatus33Choice.Proprietary))]
    #endif
    [IsoId("_7lZ_IOB9Eei2UYJ62ws-Fw")]
    [DisplayName("Matching Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus33Choice_
    #else
    public abstract partial class MatchingStatus33Choice_
    #endif
    {
    }
}
