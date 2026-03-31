// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the reason for rejecting the case assignment.
/// </summary>
[IsoId("_VJDig9p-Ed-ak6NoX_4Aeg_-1410536131")]
[DisplayName("Case Assignment Rejection Justification")]
public record CaseAssignmentRejectionJustification
{
    /// <summary>
    /// Reason for the rejection of a case assignment, in a coded form.
    /// </summary>
    [IsoId("_VJDihNp-Ed-ak6NoX_4Aeg_-1371748328")]
    [DisplayName("Rejection Reason")]
    [IsoXmlTag("RjctnRsn")]
    public required CaseAssignmentRejection1Code RejectionReason { get; init; }
}
