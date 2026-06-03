// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(InstructionProcessingStatus60Choice.Cancelled))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.Forwarded))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.Rejected))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.Pending))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.Returned))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.DefaultAction))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.StandingInstruction))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.ReceivedByIssuerOrOfferor))]
    [KnownType(typeof(InstructionProcessingStatus60Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.Cancelled), nameof(InstructionProcessingStatus60Choice.Cancelled))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.AcceptedForFurtherProcessing), nameof(InstructionProcessingStatus60Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.Forwarded), nameof(InstructionProcessingStatus60Choice.Forwarded))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.Rejected), nameof(InstructionProcessingStatus60Choice.Rejected))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.Pending), nameof(InstructionProcessingStatus60Choice.Pending))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.Returned), nameof(InstructionProcessingStatus60Choice.Returned))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.DefaultAction), nameof(InstructionProcessingStatus60Choice.DefaultAction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.StandingInstruction), nameof(InstructionProcessingStatus60Choice.StandingInstruction))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.ReceivedByIssuerOrOfferor), nameof(InstructionProcessingStatus60Choice.ReceivedByIssuerOrOfferor))]
    [JsonDerivedType(typeof(InstructionProcessingStatus60Choice.ProprietaryStatus), nameof(InstructionProcessingStatus60Choice.ProprietaryStatus))]
    [IsoId("_rmKAkY74EfCbNJ3GwkFTcw")]
    [DisplayName("Instruction Processing Status 60 Choice")]
    public abstract record InstructionProcessingStatus60Choice_ { }
}
