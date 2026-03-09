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
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus47Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus47Choice.Uncovered))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Accepted),nameof(InstructionProcessingStatus47Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Cancelled),nameof(InstructionProcessingStatus47Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus47Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Rejected),nameof(InstructionProcessingStatus47Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Pending),nameof(InstructionProcessingStatus47Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.PendingCancellation),nameof(InstructionProcessingStatus47Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Covered),nameof(InstructionProcessingStatus47Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus47Choice.Uncovered),nameof(InstructionProcessingStatus47Choice.Uncovered))]
    #endif
    [IsoId("_J-0HaRn1EeyroI8qKgB7Mg")]
    [DisplayName("Instruction Processing Status 47 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus47Choice_
    #else
    public abstract partial class InstructionProcessingStatus47Choice_
    #endif
    {
    }
}
