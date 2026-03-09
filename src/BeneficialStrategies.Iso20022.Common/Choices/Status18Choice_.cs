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
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status18Choice.Proprietary))]
    [KnownType(typeof(Status18Choice.MatchingStatus))]
    [KnownType(typeof(Status18Choice.InferredMatchingStatus))]
    [KnownType(typeof(Status18Choice.SettlementStatus))]
    [KnownType(typeof(Status18Choice.InstructionProcessingStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Status18Choice.Proprietary),nameof(Status18Choice.Proprietary))]
    [JsonDerivedType(typeof(Status18Choice.MatchingStatus),nameof(Status18Choice.MatchingStatus))]
    [JsonDerivedType(typeof(Status18Choice.InferredMatchingStatus),nameof(Status18Choice.InferredMatchingStatus))]
    [JsonDerivedType(typeof(Status18Choice.SettlementStatus),nameof(Status18Choice.SettlementStatus))]
    [JsonDerivedType(typeof(Status18Choice.InstructionProcessingStatus),nameof(Status18Choice.InstructionProcessingStatus))]
    #endif
    [IsoId("_gi4k0TnuEeWfSKvvZlhRKg")]
    [DisplayName("Status 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Status18Choice_
    #else
    public abstract partial class Status18Choice_
    #endif
    {
    }
}
