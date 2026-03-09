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
    /// Choice of format for the instruction processing status.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus10Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus10Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.PendingProcessing),nameof(InstructionProcessingStatus10Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.CancellationRequested),nameof(InstructionProcessingStatus10Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus10Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.Cancelled),nameof(InstructionProcessingStatus10Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.Generated),nameof(InstructionProcessingStatus10Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.Repair),nameof(InstructionProcessingStatus10Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.PendingCancellation),nameof(InstructionProcessingStatus10Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus10Choice.ModificationRequested),nameof(InstructionProcessingStatus10Choice.ModificationRequested))]
    #endif
    [IsoId("_4BGdO_8dEeCrw_OT0uBMXQ")]
    [DisplayName("Instruction Processing Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus10Choice_
    #else
    public abstract partial class InstructionProcessingStatus10Choice_
    #endif
    {
    }
}
