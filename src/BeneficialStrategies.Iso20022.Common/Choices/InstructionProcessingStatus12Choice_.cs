// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus12Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus12Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.Cancelled),
        nameof(InstructionProcessingStatus12Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus12Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.Rejected),
        nameof(InstructionProcessingStatus12Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.Pending),
        nameof(InstructionProcessingStatus12Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.DefaultAction),
        nameof(InstructionProcessingStatus12Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.StandingInstruction),
        nameof(InstructionProcessingStatus12Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus12Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus12Choice.ProprietaryStatus)
    )]
    [IsoId("_lg96YRN-EeKyONjZVQUqzg")]
    [DisplayName("Instruction Processing Status 12 Choice")]
    public abstract record InstructionProcessingStatus12Choice_ { }
}
