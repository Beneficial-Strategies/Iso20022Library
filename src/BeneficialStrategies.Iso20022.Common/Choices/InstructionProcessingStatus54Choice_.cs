// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status54Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus54Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus54Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus54Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus54Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus54Choice.ProprietaryStatus))]
    [KnownType(typeof(InstructionProcessingStatus54Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus54Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus54Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.Cancelled),nameof(InstructionProcessingStatus54Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.DefaultAction),nameof(InstructionProcessingStatus54Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.Pending),nameof(InstructionProcessingStatus54Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.ProprietaryStatus),nameof(InstructionProcessingStatus54Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.Rejected),nameof(InstructionProcessingStatus54Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus54Choice.StandingInstruction),nameof(InstructionProcessingStatus54Choice.StandingInstruction))]
    [IsoId("_UqcJB3SdEe6VWZz2tTgENw")]
    [DisplayName("Instruction Processing Status54Choice")]
    public abstract partial record InstructionProcessingStatus54Choice_
    {
    }
}
