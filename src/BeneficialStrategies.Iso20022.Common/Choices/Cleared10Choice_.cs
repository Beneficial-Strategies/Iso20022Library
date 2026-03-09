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
    [KnownType(typeof(Cleared10Choice.Cleared))]
    [KnownType(typeof(Cleared10Choice.NonCleared))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cleared10Choice.Cleared),nameof(Cleared10Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared10Choice.NonCleared),nameof(Cleared10Choice.NonCleared))]
    #endif
    [IsoId("_HMdnQbQ0EemI67HK7aviyg")]
    [DisplayName("Cleared 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cleared10Choice_
    #else
    public abstract partial class Cleared10Choice_
    #endif
    {
    }
}
