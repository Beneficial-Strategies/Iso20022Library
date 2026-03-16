// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatus2Choice.Confirmation))]
    [KnownType(typeof(InvestigationStatus2Choice.RejectedModification))]
    [KnownType(typeof(InvestigationStatus2Choice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatus2Choice.AssignmentCancellationConfirmation))]
    [JsonDerivedType(
        typeof(InvestigationStatus2Choice.Confirmation),
        nameof(InvestigationStatus2Choice.Confirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus2Choice.RejectedModification),
        nameof(InvestigationStatus2Choice.RejectedModification)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus2Choice.DuplicateOf),
        nameof(InvestigationStatus2Choice.DuplicateOf)
    )]
    [JsonDerivedType(
        typeof(InvestigationStatus2Choice.AssignmentCancellationConfirmation),
        nameof(InvestigationStatus2Choice.AssignmentCancellationConfirmation)
    )]
    [IsoId("_T-P8RNp-Ed-ak6NoX_4Aeg_523812389")]
    [DisplayName("Investigation Status 2 Choice")]
    public abstract record InvestigationStatus2Choice_ { }
}
