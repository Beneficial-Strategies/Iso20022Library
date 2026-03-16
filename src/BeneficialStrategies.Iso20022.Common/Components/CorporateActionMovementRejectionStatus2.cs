// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the rejection of a movement cancellation request.
/// </summary>
[IsoId("_RlNoVdp-Ed-ak6NoX_4Aeg_1541470017")]
[DisplayName("Corporate Action Movement Rejection Status")]
public record CorporateActionMovementRejectionStatus2
{
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RlNoVtp-Ed-ak6NoX_4Aeg_1616278160")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason14FormatChoice_> Reason { get; init; } = [];

    // ID for the above is _RlNoVtp-Ed-ak6NoX_4Aeg_1616278160

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlNoV9p-Ed-ak6NoX_4Aeg_1616278191")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
