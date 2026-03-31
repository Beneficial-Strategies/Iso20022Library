// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus40Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus40Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.Cancelled),
        nameof(InstructionProcessingStatus40Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus40Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.Rejected),
        nameof(InstructionProcessingStatus40Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.Pending),
        nameof(InstructionProcessingStatus40Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.DefaultAction),
        nameof(InstructionProcessingStatus40Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.StandingInstruction),
        nameof(InstructionProcessingStatus40Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus40Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus40Choice.ProprietaryStatus)
    )]
    [IsoId("_abidwe6BEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Processing Status 40 Choice")]
    public abstract record InstructionProcessingStatus40Choice_ { }
}
