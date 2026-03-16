// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the corporate action reversal occurs.
/// </summary>
[IsoId("_TsubCF99Ee262vCSVgjImg")]
[DisplayName("Corporate Action Reversal Reason")]
public record CorporateActionReversalReason6
{
    /// <summary>
    /// Specifies the reason for the reversal.
    /// </summary>
    [IsoId("_TsubDF99Ee262vCSVgjImg")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CorporateActionReversalReason6Choice_ Reason { get; init; }

    /// <summary>
    /// Provides additional information about the processed instruction.
    /// </summary>
    [IsoId("_TsubDl99Ee262vCSVgjImg")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoRestrictedFINXMax256Text? AdditionalReasonInformation { get; init; }
}
