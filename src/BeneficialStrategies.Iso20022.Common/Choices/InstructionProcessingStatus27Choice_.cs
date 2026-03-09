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
    [KnownType(typeof(InstructionProcessingStatus27Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus27Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.PendingProcessing),nameof(InstructionProcessingStatus27Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.CancellationRequested),nameof(InstructionProcessingStatus27Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus27Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.Cancelled),nameof(InstructionProcessingStatus27Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.Generated),nameof(InstructionProcessingStatus27Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.Repair),nameof(InstructionProcessingStatus27Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.PendingCancellation),nameof(InstructionProcessingStatus27Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus27Choice.ModificationRequested),nameof(InstructionProcessingStatus27Choice.ModificationRequested))]
    #endif
    [IsoId("_8VJItZNLEeWGlc8L7oPDIg")]
    [DisplayName("Instruction Processing Status 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus27Choice_
    #else
    public abstract partial class InstructionProcessingStatus27Choice_
    #endif
    {
    }
}
