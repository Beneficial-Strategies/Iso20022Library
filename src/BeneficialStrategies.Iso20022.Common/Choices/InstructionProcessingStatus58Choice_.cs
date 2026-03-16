// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Instruction Processing Status58Choice.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus58Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.Forwarded))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.ProprietaryStatus))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.ReceivedByIssuerOrOfferor))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.Returned))]
    [KnownType(typeof(InstructionProcessingStatus58Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.AcceptedForFurtherProcessing),nameof(InstructionProcessingStatus58Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.Cancelled),nameof(InstructionProcessingStatus58Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.DefaultAction),nameof(InstructionProcessingStatus58Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.Forwarded),nameof(InstructionProcessingStatus58Choice.Forwarded))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.Pending),nameof(InstructionProcessingStatus58Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.ProprietaryStatus),nameof(InstructionProcessingStatus58Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.ReceivedByIssuerOrOfferor),nameof(InstructionProcessingStatus58Choice.ReceivedByIssuerOrOfferor))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.Rejected),nameof(InstructionProcessingStatus58Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.Returned),nameof(InstructionProcessingStatus58Choice.Returned))]
    [JsonDerivedType(typeof(InstructionProcessingStatus58Choice.StandingInstruction),nameof(InstructionProcessingStatus58Choice.StandingInstruction))]
    [IsoId("_kLozdJt3Ee-wQIOX0djF2w")]
    [DisplayName("Instruction Processing Status58Choice")]
    public abstract partial record InstructionProcessingStatus58Choice_
    {
    }
}
