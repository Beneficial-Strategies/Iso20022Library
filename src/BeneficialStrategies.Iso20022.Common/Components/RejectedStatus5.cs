// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is rejected.
/// </summary>
[IsoId("_REuxdtp-Ed-ak6NoX_4Aeg_1075057449")]
[DisplayName("Rejected Status")]
public record RejectedStatus5
{
    /// <summary>
    /// Reason for a rejected status.
    /// </summary>
    [IsoId("_REuxd9p-Ed-ak6NoX_4Aeg_1865326664")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedStatusReason6Code Reason { get; init; }

    /// <summary>
    /// Reason for a rejected status.
    /// </summary>
    [IsoId("_REuxeNp-Ed-ak6NoX_4Aeg_1878257837")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoExtended350Code ExtendedReason { get; init; }
}
