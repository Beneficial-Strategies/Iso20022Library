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
    [KnownType(typeof(MatchingStatus23Choice.Matched))]
    [KnownType(typeof(MatchingStatus23Choice.MatchedWithTolerance))]
    [KnownType(typeof(MatchingStatus23Choice.MatchingAlleged))]
    [KnownType(typeof(MatchingStatus23Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus23Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus23Choice.Matched),nameof(MatchingStatus23Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.MatchedWithTolerance),nameof(MatchingStatus23Choice.MatchedWithTolerance))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.MatchingAlleged),nameof(MatchingStatus23Choice.MatchingAlleged))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.Unmatched),nameof(MatchingStatus23Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus23Choice.ProprietaryStatus),nameof(MatchingStatus23Choice.ProprietaryStatus))]
    #endif
    [IsoId("_0pUxkWXREeOWzsrIp2keDA")]
    [DisplayName("Matching Status 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus23Choice_
    #else
    public abstract partial class MatchingStatus23Choice_
    #endif
    {
    }
}
