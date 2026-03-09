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
    /// Indicates whether the contract was cleared, not cleared or if the contract is intended to be cleared.
    /// </summary>
    [KnownType(typeof(Cleared23Choice.Cleared))]
    [KnownType(typeof(Cleared23Choice.IntendToClear))]
    [KnownType(typeof(Cleared23Choice.NonCleared))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cleared23Choice.Cleared),nameof(Cleared23Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared23Choice.IntendToClear),nameof(Cleared23Choice.IntendToClear))]
    [JsonDerivedType(typeof(Cleared23Choice.NonCleared),nameof(Cleared23Choice.NonCleared))]
    #endif
    [IsoId("_zVhWIQtuEe2eQ-C-GTDpFA")]
    [DisplayName("Cleared 23 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cleared23Choice_
    #else
    public abstract partial class Cleared23Choice_
    #endif
    {
    }
}
