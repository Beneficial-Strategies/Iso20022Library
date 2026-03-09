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
    /// Identification of the executing party.
    /// </summary>
    [KnownType(typeof(ExecutingParty1Choice.Person))]
    [KnownType(typeof(ExecutingParty1Choice.Algorithm))]
    [KnownType(typeof(ExecutingParty1Choice.Client))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExecutingParty1Choice.Person),nameof(ExecutingParty1Choice.Person))]
    [JsonDerivedType(typeof(ExecutingParty1Choice.Algorithm),nameof(ExecutingParty1Choice.Algorithm))]
    [JsonDerivedType(typeof(ExecutingParty1Choice.Client),nameof(ExecutingParty1Choice.Client))]
    #endif
    [IsoId("_FVhI0ViJEea-d4CsgzjlAw")]
    [DisplayName("Executing Party 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExecutingParty1Choice_
    #else
    public abstract partial class ExecutingParty1Choice_
    #endif
    {
    }
}
