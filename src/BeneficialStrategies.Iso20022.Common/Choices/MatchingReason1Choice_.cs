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
    [KnownType(typeof(MatchingReason1Choice.Reason))]
    [KnownType(typeof(MatchingReason1Choice.NoSpecifiedReason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MatchingReason1Choice.Reason),nameof(MatchingReason1Choice.Reason))]
    [JsonDerivedType(typeof(MatchingReason1Choice.NoSpecifiedReason),nameof(MatchingReason1Choice.NoSpecifiedReason))]
    #endif
    [IsoId("_Az7z09okEeC60axPepSq7g_944348200")]
    [DisplayName("Matching Reason 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MatchingReason1Choice_
    #else
    public abstract partial class MatchingReason1Choice_
    #endif
    {
    }
}
