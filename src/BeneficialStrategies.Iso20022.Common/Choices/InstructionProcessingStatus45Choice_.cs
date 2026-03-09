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
    /// Choice of formats for an instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus45Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus45Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.PendingProcessing),nameof(InstructionProcessingStatus45Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.CancellationRequested),nameof(InstructionProcessingStatus45Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus45Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.Cancelled),nameof(InstructionProcessingStatus45Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.Generated),nameof(InstructionProcessingStatus45Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.Repair),nameof(InstructionProcessingStatus45Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.PendingCancellation),nameof(InstructionProcessingStatus45Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus45Choice.ModificationRequested),nameof(InstructionProcessingStatus45Choice.ModificationRequested))]
    #endif
    [IsoId("_waWtlSAeEeuyDZ-ukt4YRg")]
    [DisplayName("Instruction Processing Status 45 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus45Choice_
    #else
    public abstract partial class InstructionProcessingStatus45Choice_
    #endif
    {
    }
}
