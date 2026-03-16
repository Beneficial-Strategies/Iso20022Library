// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information of an election advice.
/// </summary>
[IsoId("_RlD3Vdp-Ed-ak6NoX_4Aeg_-1533879577")]
[DisplayName("Corporate Action Cancellation Processing Status")]
public record CorporateActionCancellationProcessingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RlD3Vtp-Ed-ak6NoX_4Aeg_-1520950491")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus5FormatChoice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlD3V9p-Ed-ak6NoX_4Aeg_-1520950490")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
