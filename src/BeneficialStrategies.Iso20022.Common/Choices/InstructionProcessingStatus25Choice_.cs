// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus25Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus25Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.Cancelled),
        nameof(InstructionProcessingStatus25Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus25Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.Rejected),
        nameof(InstructionProcessingStatus25Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.Pending),
        nameof(InstructionProcessingStatus25Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.DefaultAction),
        nameof(InstructionProcessingStatus25Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.StandingInstruction),
        nameof(InstructionProcessingStatus25Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus25Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus25Choice.ProprietaryStatus)
    )]
    [IsoId("_cgnRW5KQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Processing Status 25 Choice")]
    public abstract record InstructionProcessingStatus25Choice_ { }
}
