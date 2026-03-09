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
    [KnownType(typeof(InstructionProcessingStatus3Choice.PendingProcessing))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.CancellationRequested))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.AcknowledgedAccepted))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.Generated))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.Repair))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus3Choice.ModificationRequested))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.PendingProcessing),nameof(InstructionProcessingStatus3Choice.PendingProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.CancellationRequested),nameof(InstructionProcessingStatus3Choice.CancellationRequested))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.AcknowledgedAccepted),nameof(InstructionProcessingStatus3Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.Cancelled),nameof(InstructionProcessingStatus3Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.Generated),nameof(InstructionProcessingStatus3Choice.Generated))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.Repair),nameof(InstructionProcessingStatus3Choice.Repair))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.PendingCancellation),nameof(InstructionProcessingStatus3Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus3Choice.ModificationRequested),nameof(InstructionProcessingStatus3Choice.ModificationRequested))]
    #endif
    [IsoId("_UZXyCNp-Ed-ak6NoX_4Aeg_-1794343112")]
    [DisplayName("Instruction Processing Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus3Choice_
    #else
    public abstract partial class InstructionProcessingStatus3Choice_
    #endif
    {
    }
}
