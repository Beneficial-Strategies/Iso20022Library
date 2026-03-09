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
    [KnownType(typeof(InstructionProcessingStatus14Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus14Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.PendingProcessing),nameof(InstructionProcessingStatus14Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.CancellationRequested),nameof(InstructionProcessingStatus14Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus14Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.Cancelled),nameof(InstructionProcessingStatus14Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.Generated),nameof(InstructionProcessingStatus14Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.Repair),nameof(InstructionProcessingStatus14Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.PendingCancellation),nameof(InstructionProcessingStatus14Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus14Choice.ModificationRequested),nameof(InstructionProcessingStatus14Choice.ModificationRequested))]
    #endif
    [IsoId("_EU___SRhEeO8sskhVI3IDA")]
    [DisplayName("Instruction Processing Status 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus14Choice_
    #else
    public abstract partial class InstructionProcessingStatus14Choice_
    #endif
    {
    }
}
