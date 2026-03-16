// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus31Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus31Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.Cancelled),
        nameof(InstructionProcessingStatus31Choice.Cancelled)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.AcceptedForFurtherProcessing),
        nameof(InstructionProcessingStatus31Choice.AcceptedForFurtherProcessing)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.Rejected),
        nameof(InstructionProcessingStatus31Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.Pending),
        nameof(InstructionProcessingStatus31Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.DefaultAction),
        nameof(InstructionProcessingStatus31Choice.DefaultAction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.StandingInstruction),
        nameof(InstructionProcessingStatus31Choice.StandingInstruction)
    )]
    [JsonDerivedType(
        typeof(InstructionProcessingStatus31Choice.ProprietaryStatus),
        nameof(InstructionProcessingStatus31Choice.ProprietaryStatus)
    )]
    [IsoId("_pHzPUbXTEeiTob_PrFFUxA")]
    [DisplayName("Instruction Processing Status 31 Choice")]
    public abstract record InstructionProcessingStatus31Choice_ { }
}
