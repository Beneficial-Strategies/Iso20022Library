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
    [KnownType(typeof(InstructionProcessingStatus43Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.PendingCancellation))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Covered))]
    [KnownType(typeof(InstructionProcessingStatus43Choice.Uncovered))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.Accepted),nameof(InstructionProcessingStatus43Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.Cancelled),nameof(InstructionProcessingStatus43Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus43Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.Rejected),nameof(InstructionProcessingStatus43Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.Pending),nameof(InstructionProcessingStatus43Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.PendingCancellation),nameof(InstructionProcessingStatus43Choice.PendingCancellation))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.Covered),nameof(InstructionProcessingStatus43Choice.Covered))]
    [JsonDerivedType(typeof(InstructionProcessingStatus43Choice.Uncovered),nameof(InstructionProcessingStatus43Choice.Uncovered))]
    #endif
    [IsoId("_pUH1qR9QEeuFz_FaCzCLgQ")]
    [DisplayName("Instruction Processing Status 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus43Choice_
    #else
    public abstract partial class InstructionProcessingStatus43Choice_
    #endif
    {
    }
}
