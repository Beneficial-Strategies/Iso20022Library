// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatus4Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus4Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus4Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus4Choice.AssignmentCancellationConfirmation))]
    [JsonDerivedType(
        typeof(InvestigationStatus4Choice.Confirmation),
        nameof(InvestigationStatus4Choice.Confirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus4Choice.RejectedModification),
        nameof(InvestigationStatus4Choice.RejectedModification)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus4Choice.DuplicateOf),
        nameof(InvestigationStatus4Choice.DuplicateOf)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus4Choice.AssignmentCancellationConfirmation),
        nameof(InvestigationStatus4Choice.AssignmentCancellationConfirmation)
    )]
    [IsoId("_nTQy8YmxEeeKR__nUfxjwA")]
    [DisplayName("Investigation Status 4 Choice")]
    public abstract record InvestigationStatus4Choice_ { }
}
