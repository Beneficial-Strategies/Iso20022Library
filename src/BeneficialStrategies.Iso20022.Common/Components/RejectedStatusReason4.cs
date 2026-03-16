// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected status.
/// </summary>
[IsoId("_U3BXWNp-Ed-ak6NoX_4Aeg_2072956461")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason4
{
    /// <summary>
    /// Reason for a rejected status in structured form.
    /// </summary>
    [IsoId("_U3BXWdp-Ed-ak6NoX_4Aeg_2072956480")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required RejectedStatusReason4Code Structured { get; init; }

    /// <summary>
    /// Reason for a rejected status in free format text.
    /// </summary>
    [IsoId("_U3BXWtp-Ed-ak6NoX_4Aeg_2072956762")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
