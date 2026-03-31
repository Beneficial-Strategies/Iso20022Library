// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Status6Choice.
    /// </summary>
    [KnownType(typeof(InvestigationStatus6Choice.AssignmentCancellationConfirmation))]
    [KnownType(typeof(InvestigationStatus6Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus6Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus6Choice.RejectedModification))]
    [JsonDerivedType(
        typeof(InvestigationStatus6Choice.AssignmentCancellationConfirmation),
        nameof(InvestigationStatus6Choice.AssignmentCancellationConfirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus6Choice.Confirmation),
        nameof(InvestigationStatus6Choice.Confirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus6Choice.DuplicateOf),
        nameof(InvestigationStatus6Choice.DuplicateOf)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus6Choice.RejectedModification),
        nameof(InvestigationStatus6Choice.RejectedModification)
    )]
    [IsoId("_w8w1UTEyEe6g-ffJsqGiSA")]
    [DisplayName("Investigation Status6Choice")]
    public abstract record InvestigationStatus6Choice_ { }
}
