// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reason of the rejection of a standing instruction request.
/// </summary>
[IsoId("_RlD3Utp-Ed-ak6NoX_4Aeg_-526029435")]
[DisplayName("Corporate Action Standing Instruction Rejection Status")]
public record CorporateActionStandingInstructionRejectionStatus1
{
    /// <summary>
    /// The rejection reason.
    /// </summary>
    [IsoId("_RlD3U9p-Ed-ak6NoX_4Aeg_-484468439")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public ValueList<RejectionReason20FormatChoice_> Reason { get; init; } = [];

    // ID for the above is _RlD3U9p-Ed-ak6NoX_4Aeg_-484468439

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlD3VNp-Ed-ak6NoX_4Aeg_-484468418")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
