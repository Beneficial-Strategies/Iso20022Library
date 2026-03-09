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
    [KnownType(typeof(MatchingStatus2Choice.Matched))]
    [KnownType(typeof(MatchingStatus2Choice.Unmatched))]
    [KnownType(typeof(MatchingStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingStatus2Choice.Matched),nameof(MatchingStatus2Choice.Matched))]
    [JsonDerivedType(typeof(MatchingStatus2Choice.Unmatched),nameof(MatchingStatus2Choice.Unmatched))]
    [JsonDerivedType(typeof(MatchingStatus2Choice.Proprietary),nameof(MatchingStatus2Choice.Proprietary))]
    #endif
    [IsoId("_UaHY6Np-Ed-ak6NoX_4Aeg_-283039310")]
    [DisplayName("Matching Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingStatus2Choice_
    #else
    public abstract partial class MatchingStatus2Choice_
    #endif
    {
    }
}
