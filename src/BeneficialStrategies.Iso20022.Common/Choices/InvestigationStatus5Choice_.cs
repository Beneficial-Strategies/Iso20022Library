// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatus5Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus5Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus5Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus5Choice.AssignmentCancellationConfirmation))]
    [JsonDerivedType(
        typeof(InvestigationStatus5Choice.Confirmation),
        nameof(InvestigationStatus5Choice.Confirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus5Choice.RejectedModification),
        nameof(InvestigationStatus5Choice.RejectedModification)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus5Choice.DuplicateOf),
        nameof(InvestigationStatus5Choice.DuplicateOf)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus5Choice.AssignmentCancellationConfirmation),
        nameof(InvestigationStatus5Choice.AssignmentCancellationConfirmation)
    )]
    [IsoId("_NIe3H249EeiU9cctagi5ow")]
    [DisplayName("Investigation Status 5 Choice")]
    public abstract record InvestigationStatus5Choice_ { }
}
