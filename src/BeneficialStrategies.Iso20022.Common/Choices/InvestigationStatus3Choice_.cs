// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatus3Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus3Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus3Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus3Choice.AssignmentCancellationConfirmation))]
    [JsonDerivedType(
        typeof(InvestigationStatus3Choice.Confirmation),
        nameof(InvestigationStatus3Choice.Confirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus3Choice.RejectedModification),
        nameof(InvestigationStatus3Choice.RejectedModification)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus3Choice.DuplicateOf),
        nameof(InvestigationStatus3Choice.DuplicateOf)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus3Choice.AssignmentCancellationConfirmation),
        nameof(InvestigationStatus3Choice.AssignmentCancellationConfirmation)
    )]
    [IsoId("_tx5SAVkyEeGeoaLUQk__nA_-868345500")]
    [DisplayName("Investigation Status 3 Choice")]
    public abstract record InvestigationStatus3Choice_ { }
}
