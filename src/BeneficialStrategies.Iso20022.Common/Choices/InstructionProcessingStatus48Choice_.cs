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
    [KnownType(typeof(InstructionProcessingStatus48Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus48Choice.Uncovered))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.Accepted),nameof(InstructionProcessingStatus48Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.Cancelled),nameof(InstructionProcessingStatus48Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus48Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.Rejected),nameof(InstructionProcessingStatus48Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.Pending),nameof(InstructionProcessingStatus48Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.PendingCancellation),nameof(InstructionProcessingStatus48Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.Covered),nameof(InstructionProcessingStatus48Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus48Choice.Uncovered),nameof(InstructionProcessingStatus48Choice.Uncovered))]
    #endif
    [IsoId("_pf9iPTi7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Processing Status 48 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus48Choice_
    #else
    public abstract partial class InstructionProcessingStatus48Choice_
    #endif
    {
    }
}
