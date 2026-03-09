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
    /// Information for the first side of the transaction.
    /// </summary>
    [KnownType(typeof(Cleared4Choice.Cleared))]
    [KnownType(typeof(Cleared4Choice.NonCleared))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Cleared4Choice.Cleared),nameof(Cleared4Choice.Cleared))]
    [JsonDerivedType(typeof(Cleared4Choice.NonCleared),nameof(Cleared4Choice.NonCleared))]
    #endif
    [IsoId("_UM6SwCUMEeeDvf1E8-5blA")]
    [DisplayName("Cleared 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Cleared4Choice_
    #else
    public abstract partial class Cleared4Choice_
    #endif
    {
    }
}
