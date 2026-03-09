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
    [KnownType(typeof(MatchingStatus8Choice.Code))]
    [KnownType(typeof(MatchingStatus8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus8Choice.Code),nameof(MatchingStatus8Choice.Code))]
    [JsonDerivedType(typeof(MatchingStatus8Choice.Proprietary),nameof(MatchingStatus8Choice.Proprietary))]
    #endif
    [IsoId("_A0Fk09okEeC60axPepSq7g_-730589199")]
    [DisplayName("Matching Status 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus8Choice_
    #else
    public abstract partial class MatchingStatus8Choice_
    #endif
    {
    }
}
