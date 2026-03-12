// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus49Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus49Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.Cancelled),nameof(InstructionProcessingStatus49Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus49Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.Rejected),nameof(InstructionProcessingStatus49Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.Pending),nameof(InstructionProcessingStatus49Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.DefaultAction),nameof(InstructionProcessingStatus49Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.StandingInstruction),nameof(InstructionProcessingStatus49Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus49Choice.ProprietaryStatus),nameof(InstructionProcessingStatus49Choice.ProprietaryStatus))]
    [IsoId("_piIs-ji7Eeydid5dcNPKvg")]
    [DisplayName("Instruction Processing Status 49 Choice")]
    public abstract partial record InstructionProcessingStatus49Choice_
    {
    }
}
