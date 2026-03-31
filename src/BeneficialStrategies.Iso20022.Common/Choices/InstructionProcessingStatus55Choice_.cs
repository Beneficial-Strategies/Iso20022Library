// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status55Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus55Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.Forwarded))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.ProprietaryStatus))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.ReceivedByIssuerOrOfferor))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.Returned))]
    [KnownType(typeof(InstructionProcessingStatus55Choice.StandingInstruction))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus55Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.Cancelled),
        nameof(InstructionProcessingStatus55Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.DefaultAction),
        nameof(InstructionProcessingStatus55Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.Forwarded),
        nameof(InstructionProcessingStatus55Choice.Forwarded)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.Pending),
        nameof(InstructionProcessingStatus55Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus55Choice.ProprietaryStatus)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.ReceivedByIssuerOrOfferor),
        nameof(InstructionProcessingStatus55Choice.ReceivedByIssuerOrOfferor)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.Rejected),
        nameof(InstructionProcessingStatus55Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.Returned),
        nameof(InstructionProcessingStatus55Choice.Returned)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus55Choice.StandingInstruction),
        nameof(InstructionProcessingStatus55Choice.StandingInstruction)
    )]
    [IsoId("_3VxUMYC7Ee-eGe8fbP3Zug")]
    [DisplayName("Instruction Processing Status55Choice")]
    public abstract record InstructionProcessingStatus55Choice_ { }
}
