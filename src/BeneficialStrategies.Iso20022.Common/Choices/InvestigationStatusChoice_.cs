// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different statuses of an investigation case.
    /// </summary>
    [KnownType(typeof(InvestigationStatusChoice.Confirmation))]
    [KnownType(typeof(InvestigationStatusChoice.RejectedModification))]
    [KnownType(typeof(InvestigationStatusChoice.RejectedCancellation))]
    [KnownType(typeof(InvestigationStatusChoice.DuplicateOf))]
    [KnownType(typeof(InvestigationStatusChoice.AssignmentCancellationConfirmation))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.Confirmation),nameof(InvestigationStatusChoice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.RejectedModification),nameof(InvestigationStatusChoice.RejectedModification))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.RejectedCancellation),nameof(InvestigationStatusChoice.RejectedCancellation))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.DuplicateOf),nameof(InvestigationStatusChoice.DuplicateOf))]
    [JsonDerivedType(typeof(InvestigationStatusChoice.AssignmentCancellationConfirmation),nameof(InvestigationStatusChoice.AssignmentCancellationConfirmation))]
    [IsoId("_UuYYstp-Ed-ak6NoX_4Aeg_788596093")]
    [DisplayName("Investigation Status Choice")]
    public abstract partial record InvestigationStatusChoice_
    {
    }
}
