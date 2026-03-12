// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus38Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus38Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.Cancelled),nameof(InstructionProcessingStatus38Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus38Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.Rejected),nameof(InstructionProcessingStatus38Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.Pending),nameof(InstructionProcessingStatus38Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.DefaultAction),nameof(InstructionProcessingStatus38Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.StandingInstruction),nameof(InstructionProcessingStatus38Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus38Choice.ProprietaryStatus),nameof(InstructionProcessingStatus38Choice.ProprietaryStatus))]
    [IsoId("_lbnRIeXyEemEj48jhmlA0Q")]
    [DisplayName("Instruction Processing Status 38 Choice")]
    public abstract partial record InstructionProcessingStatus38Choice_
    {
    }
}
