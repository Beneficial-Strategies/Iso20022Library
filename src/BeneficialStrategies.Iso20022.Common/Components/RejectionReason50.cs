// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a rejected status.
/// </summary>
[IsoId("_mHfQYQVGEeq4ZaI1b_-GPA")]
[DisplayName("Rejection Reason")]
public record RejectionReason50
{
    /// <summary>
    /// Reason for the rejected status.
    /// </summary>
    [IsoId("_mb3k8QVGEeq4ZaI1b_-GPA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectedReason33Choice_ Reason { get; init; }

    /// <summary>
    /// Additional information about the rejected status reason.
    /// </summary>
    [IsoId("_mb3k-QVGEeq4ZaI1b_-GPA")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalReasonInformation { get; init; }
}
