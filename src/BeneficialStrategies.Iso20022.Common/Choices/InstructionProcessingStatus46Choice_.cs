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
    [KnownType(typeof(InstructionProcessingStatus46Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus46Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus46Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus46Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus46Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus46Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus46Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.Cancelled),nameof(InstructionProcessingStatus46Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus46Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.Rejected),nameof(InstructionProcessingStatus46Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.Pending),nameof(InstructionProcessingStatus46Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.DefaultAction),nameof(InstructionProcessingStatus46Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.StandingInstruction),nameof(InstructionProcessingStatus46Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.ProprietaryStatus),nameof(InstructionProcessingStatus46Choice.ProprietaryStatus))]
    #endif
    [IsoId("_dbpa0RnyEeyroI8qKgB7Mg")]
    [DisplayName("Instruction Processing Status 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InstructionProcessingStatus46Choice_
    #else
    public abstract partial class InstructionProcessingStatus46Choice_
    #endif
    {
    }
}
