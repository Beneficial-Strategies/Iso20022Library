// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.Cancelled),nameof(InstructionProcessingStatus46Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus46Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.Rejected),nameof(InstructionProcessingStatus46Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.Pending),nameof(InstructionProcessingStatus46Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.DefaultAction),nameof(InstructionProcessingStatus46Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.StandingInstruction),nameof(InstructionProcessingStatus46Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus46Choice.ProprietaryStatus),nameof(InstructionProcessingStatus46Choice.ProprietaryStatus))]
    [IsoId("_dbpa0RnyEeyroI8qKgB7Mg")]
    [DisplayName("Instruction Processing Status 46 Choice")]
    public abstract partial record InstructionProcessingStatus46Choice_
    {
    }
}
