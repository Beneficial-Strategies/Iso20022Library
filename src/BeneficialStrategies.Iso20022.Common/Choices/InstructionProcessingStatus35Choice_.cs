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
    [KnownType(typeof(InstructionProcessingStatus35Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus35Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.PendingProcessing),nameof(InstructionProcessingStatus35Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.CancellationRequested),nameof(InstructionProcessingStatus35Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus35Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.Cancelled),nameof(InstructionProcessingStatus35Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.Generated),nameof(InstructionProcessingStatus35Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.Repair),nameof(InstructionProcessingStatus35Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.PendingCancellation),nameof(InstructionProcessingStatus35Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus35Choice.ModificationRequested),nameof(InstructionProcessingStatus35Choice.ModificationRequested))]
    #endif
    [IsoId("_iE4Oe_fZEeiNZp_PtLohLw")]
    [DisplayName("Instruction Processing Status 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus35Choice_
    #else
    public abstract partial class InstructionProcessingStatus35Choice_
    #endif
    {
    }
}
