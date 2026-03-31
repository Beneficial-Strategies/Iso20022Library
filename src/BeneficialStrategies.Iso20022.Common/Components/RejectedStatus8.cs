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
[IsoId("_WIFWmdp-Ed-ak6NoX_4Aeg_-2114215062")]
[DisplayName("Rejected Status")]
public record RejectedStatus8
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_WIPHkNp-Ed-ak6NoX_4Aeg_-2114215001")]
    [DisplayName("Extended Reason")]
    [IsoXmlTag("XtndedRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text ExtendedReason { get; init; }

    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    [IsoId("_WIPHkdp-Ed-ak6NoX_4Aeg_-2114214730")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoRestrictedFINMax210Text? AdditionalInformation { get; init; }
}
