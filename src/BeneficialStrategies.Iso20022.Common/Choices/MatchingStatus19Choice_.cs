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
    [KnownType(typeof(MatchingStatus19Choice.Matched))]
    [KnownType(typeof(MatchingStatus19Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus19Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus19Choice.Matched),nameof(MatchingStatus19Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus19Choice.Unmatched),nameof(MatchingStatus19Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus19Choice.Proprietary),nameof(MatchingStatus19Choice.Proprietary))]
    #endif
    [IsoId("_ZlY6ASwREeOEV5XHD-BKpw")]
    [DisplayName("Matching Status 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus19Choice_
    #else
    public abstract partial class MatchingStatus19Choice_
    #endif
    {
    }
}
