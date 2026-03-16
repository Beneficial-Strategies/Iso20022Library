// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a deactivation cancellation request.
/// </summary>
[IsoId("_RkeBcNp-Ed-ak6NoX_4Aeg_1505452945")]
[DisplayName("Corporate Action Deactivation Cancellation Rejection Status")]
public record CorporateActionDeactivationCancellationRejectionStatus1
{
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RkeBcdp-Ed-ak6NoX_4Aeg_1510068594")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason7FormatChoice_> Reason { get; init; } = [];

    // ID for the above is _RkeBcdp-Ed-ak6NoX_4Aeg_1510068594

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkeBctp-Ed-ak6NoX_4Aeg_1510068595")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
