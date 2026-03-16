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
[IsoId("_GI7cUUguEeazC43Xuh-e6w")]
[DisplayName("Rejected Status")]
public record RejectedStatus10
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_GjZx00guEeazC43Xuh-e6w")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public RejectedReason21Choice_? Reason { get; init; }

    /// <summary>
    /// Additional information about the rejected reason.
    /// </summary>
    [IsoId("_GjZx1UguEeazC43Xuh-e6w")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
