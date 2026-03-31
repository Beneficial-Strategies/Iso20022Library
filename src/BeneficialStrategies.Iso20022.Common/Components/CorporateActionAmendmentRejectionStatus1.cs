// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of an election amendment request.
/// </summary>
[IsoId("_RkUQc9p-Ed-ak6NoX_4Aeg_-1881122577")]
[DisplayName("Corporate Action Amendment Rejection Status")]
public record CorporateActionAmendmentRejectionStatus1
{
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RkUQdNp-Ed-ak6NoX_4Aeg_-1873733608")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason8FormatChoice_> Reason { get; init; } = [];

    // ID for the above is _RkUQdNp-Ed-ak6NoX_4Aeg_-1873733608

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RkUQddp-Ed-ak6NoX_4Aeg_-1873733607")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
