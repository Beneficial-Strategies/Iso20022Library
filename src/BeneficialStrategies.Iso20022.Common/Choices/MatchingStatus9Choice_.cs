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
    [KnownType(typeof(MatchingStatus9Choice.Matched))]
    [KnownType(typeof(MatchingStatus9Choice.MatchedWithTolerance))]
    [KnownType(typeof(MatchingStatus9Choice.MatchingAlleged))]
    [KnownType(typeof(MatchingStatus9Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus9Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus9Choice.Matched),nameof(MatchingStatus9Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.MatchedWithTolerance),nameof(MatchingStatus9Choice.MatchedWithTolerance))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.MatchingAlleged),nameof(MatchingStatus9Choice.MatchingAlleged))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.Unmatched),nameof(MatchingStatus9Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus9Choice.ProprietaryStatus),nameof(MatchingStatus9Choice.ProprietaryStatus))]
    #endif
    [IsoId("_A4aEItokEeC60axPepSq7g_-668898951")]
    [DisplayName("Matching Status 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus9Choice_
    #else
    public abstract partial class MatchingStatus9Choice_
    #endif
    {
    }
}
