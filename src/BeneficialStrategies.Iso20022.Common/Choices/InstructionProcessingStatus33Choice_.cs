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
    [KnownType(typeof(InstructionProcessingStatus33Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus33Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.PendingProcessing),nameof(InstructionProcessingStatus33Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.CancellationRequested),nameof(InstructionProcessingStatus33Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus33Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.Cancelled),nameof(InstructionProcessingStatus33Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.Generated),nameof(InstructionProcessingStatus33Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.Repair),nameof(InstructionProcessingStatus33Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.PendingCancellation),nameof(InstructionProcessingStatus33Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus33Choice.ModificationRequested),nameof(InstructionProcessingStatus33Choice.ModificationRequested))]
    #endif
    [IsoId("_IuIhmdB7EeihG9bKfarOOA")]
    [DisplayName("Instruction Processing Status 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus33Choice_
    #else
    public abstract partial class InstructionProcessingStatus33Choice_
    #endif
    {
    }
}
