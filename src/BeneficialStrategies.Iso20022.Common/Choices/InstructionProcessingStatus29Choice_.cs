// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus29Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus29Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.Cancelled),
        nameof(InstructionProcessingStatus29Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus29Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.Rejected),
        nameof(InstructionProcessingStatus29Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.Pending),
        nameof(InstructionProcessingStatus29Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.DefaultAction),
        nameof(InstructionProcessingStatus29Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.StandingInstruction),
        nameof(InstructionProcessingStatus29Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus29Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus29Choice.ProprietaryStatus)
    )]
    [IsoId("_GZT1MYlqEeavwKddCbm3hg")]
    [DisplayName("Instruction Processing Status 29 Choice")]
    public abstract record InstructionProcessingStatus29Choice_ { }
}
