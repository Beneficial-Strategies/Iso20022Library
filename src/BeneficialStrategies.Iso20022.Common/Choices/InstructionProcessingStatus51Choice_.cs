// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status51Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus51Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus51Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus51Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus51Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus51Choice.ProprietaryStatus))]
    [KnownType(typeof(InstructionProcessingStatus51Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus51Choice.StandingInstruction))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus51Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.Cancelled),
        nameof(InstructionProcessingStatus51Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.DefaultAction),
        nameof(InstructionProcessingStatus51Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.Pending),
        nameof(InstructionProcessingStatus51Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus51Choice.ProprietaryStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.Rejected),
        nameof(InstructionProcessingStatus51Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus51Choice.StandingInstruction),
        nameof(InstructionProcessingStatus51Choice.StandingInstruction)
    )]
    [IsoId("_oYFbIWHdEe6yt_d72zQZeQ")]
    [DisplayName("Instruction Processing Status51Choice")]
    public abstract record InstructionProcessingStatus51Choice_ { }
}
