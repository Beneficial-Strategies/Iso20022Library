// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus34Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus34Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus34Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus34Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus34Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus34Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus34Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.Cancelled),nameof(InstructionProcessingStatus34Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus34Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.Rejected),nameof(InstructionProcessingStatus34Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.Pending),nameof(InstructionProcessingStatus34Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.DefaultAction),nameof(InstructionProcessingStatus34Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.StandingInstruction),nameof(InstructionProcessingStatus34Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus34Choice.ProprietaryStatus),nameof(InstructionProcessingStatus34Choice.ProprietaryStatus))]
    [IsoId("_bzVOrffREeiNZp_PtLohLw")]
    [DisplayName("Instruction Processing Status 34 Choice")]
    public abstract partial record InstructionProcessingStatus34Choice_
    {
    }
}
