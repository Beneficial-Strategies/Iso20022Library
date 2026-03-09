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
    /// Choice of format for the matching processing status.
    /// </summary>
    [KnownType(typeof(MatchingReason3Choice.Reason))]
    [KnownType(typeof(MatchingReason3Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingReason3Choice.Reason),nameof(MatchingReason3Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason3Choice.NoSpecifiedReason),nameof(MatchingReason3Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_Az7z0NokEeC60axPepSq7g_-1866135956")]
    [DisplayName("Matching Reason 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingReason3Choice_
    #else
    public abstract partial class MatchingReason3Choice_
    #endif
    {
    }
}
