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
    /// Choice of status for the matching.
    /// </summary>
    [KnownType(typeof(MatchingStatus35Choice.Matched))]
    [KnownType(typeof(MatchingStatus35Choice.MatchedWithTolerance))]
    [KnownType(typeof(MatchingStatus35Choice.MatchingAlleged))]
    [KnownType(typeof(MatchingStatus35Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus35Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus35Choice.Matched),nameof(MatchingStatus35Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus35Choice.MatchedWithTolerance),nameof(MatchingStatus35Choice.MatchedWithTolerance))]
    [JsonDerivedType(typeof(MatchingStatus35Choice.MatchingAlleged),nameof(MatchingStatus35Choice.MatchingAlleged))]
    [JsonDerivedType(typeof(MatchingStatus35Choice.Unmatched),nameof(MatchingStatus35Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus35Choice.ProprietaryStatus),nameof(MatchingStatus35Choice.ProprietaryStatus))]
    #endif
    [IsoId("_2W_4UQd3Ee2fOITqoTnSLQ")]
    [DisplayName("Matching Status 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus35Choice_
    #else
    public abstract partial class MatchingStatus35Choice_
    #endif
    {
    }
}
