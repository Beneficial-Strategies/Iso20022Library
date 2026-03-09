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
    [KnownType(typeof(MatchingStatus12Choice.Matched))]
    [KnownType(typeof(MatchingStatus12Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus12Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus12Choice.Matched),nameof(MatchingStatus12Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus12Choice.Unmatched),nameof(MatchingStatus12Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus12Choice.Proprietary),nameof(MatchingStatus12Choice.Proprietary))]
    #endif
    [IsoId("_EhXs4f7ZEeCtrO5qCU90cA")]
    [DisplayName("Matching Status 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus12Choice_
    #else
    public abstract partial class MatchingStatus12Choice_
    #endif
    {
    }
}
