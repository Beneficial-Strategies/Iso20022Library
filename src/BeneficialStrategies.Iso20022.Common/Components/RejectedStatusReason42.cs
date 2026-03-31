// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for a rejected instruction status.
/// </summary>
[IsoId("_iCQ4cRrpEeyhRdHRjakS2w")]
[DisplayName("Rejected Status Reason")]
public record RejectedStatusReason42
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_iW99ExrpEeyhRdHRjakS2w")]
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason44Choice_ ReasonCode { get; init; }

    /// <summary>
    /// Additional information about the rejection status.
    /// </summary>
    [IsoId("_iW99GxrpEeyhRdHRjakS2w")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
