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
    /// Indicates whether the contract was cleared or not.
    /// </summary>
    [KnownType(typeof(Cleared12Choice.Cleared))]
    [KnownType(typeof(Cleared12Choice.IntendToClear))]
    [KnownType(typeof(Cleared12Choice.NonCleared))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cleared12Choice.Cleared),nameof(Cleared12Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared12Choice.IntendToClear),nameof(Cleared12Choice.IntendToClear))]
    [JsonDerivedType(typeof(Cleared12Choice.NonCleared),nameof(Cleared12Choice.NonCleared))]
    #endif
    [IsoId("_BT5_1-xYEemioJdkOVFBdw")]
    [DisplayName("Cleared 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cleared12Choice_
    #else
    public abstract partial class Cleared12Choice_
    #endif
    {
    }
}
