// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reasons for a pending instruction status.
/// </summary>
[IsoId("_wz3WGrKdEemux5trsZcCpw")]
[DisplayName("Pending Status Reason")]
public record PendingStatusReason16
{
    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_wz3WHbKdEemux5trsZcCpw")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required PendingReason51Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the pending status.
    /// </summary>
    [IsoId("_wz3WHLKdEemux5trsZcCpw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
