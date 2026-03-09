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
    [KnownType(typeof(InstructionProcessingStatus41Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus41Choice.Uncovered))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.Accepted),nameof(InstructionProcessingStatus41Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.Cancelled),nameof(InstructionProcessingStatus41Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus41Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.Rejected),nameof(InstructionProcessingStatus41Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.Pending),nameof(InstructionProcessingStatus41Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.PendingCancellation),nameof(InstructionProcessingStatus41Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.Covered),nameof(InstructionProcessingStatus41Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus41Choice.Uncovered),nameof(InstructionProcessingStatus41Choice.Uncovered))]
    #endif
    [IsoId("_4FWsSe6KEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Processing Status 41 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus41Choice_
    #else
    public abstract partial class InstructionProcessingStatus41Choice_
    #endif
    {
    }
}
