// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus7Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus7Choice.Accepted))]
    [KnownType(typeof(InstructionProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus7Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus7Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus7Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus7Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.Cancelled),nameof(InstructionProcessingStatus7Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.Accepted),nameof(InstructionProcessingStatus7Choice.Accepted))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.Rejected),nameof(InstructionProcessingStatus7Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.Pending),nameof(InstructionProcessingStatus7Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.DefaultAction),nameof(InstructionProcessingStatus7Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.StandingInstruction),nameof(InstructionProcessingStatus7Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus7Choice.ProprietaryStatus),nameof(InstructionProcessingStatus7Choice.ProprietaryStatus))]
    [IsoId("_U3YuAeJxEd-Q6MzBzY5WkA")]
    [DisplayName("Instruction Processing Status 7 Choice")]
    public abstract partial record InstructionProcessingStatus7Choice_
    {
    }
}
