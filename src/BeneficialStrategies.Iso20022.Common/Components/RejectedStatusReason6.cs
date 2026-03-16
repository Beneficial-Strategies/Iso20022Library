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
[IsoId("_U3LIWdp-Ed-ak6NoX_4Aeg_-136853846")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason6
{
    /// <summary>
    /// Reason for a rejected status in structured form.
    /// </summary>
    [IsoId("_U3LIWtp-Ed-ak6NoX_4Aeg_-136853820")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required RejectedStatusReason5Code Structured { get; init; }

    /// <summary>
    /// Reason for a rejected status in free format text.
    /// </summary>
    [IsoId("_U3LIW9p-Ed-ak6NoX_4Aeg_-136853509")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
