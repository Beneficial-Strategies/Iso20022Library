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
    [KnownType(typeof(InstructionProcessingStatus42Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus42Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.PendingProcessing),nameof(InstructionProcessingStatus42Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.CancellationRequested),nameof(InstructionProcessingStatus42Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus42Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.Cancelled),nameof(InstructionProcessingStatus42Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.Generated),nameof(InstructionProcessingStatus42Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.Repair),nameof(InstructionProcessingStatus42Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.PendingCancellation),nameof(InstructionProcessingStatus42Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus42Choice.ModificationRequested),nameof(InstructionProcessingStatus42Choice.ModificationRequested))]
    #endif
    [IsoId("_7KKTcQpJEeup4r-PFG2T5Q")]
    [DisplayName("Instruction Processing Status 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus42Choice_
    #else
    public abstract partial class InstructionProcessingStatus42Choice_
    #endif
    {
    }
}
