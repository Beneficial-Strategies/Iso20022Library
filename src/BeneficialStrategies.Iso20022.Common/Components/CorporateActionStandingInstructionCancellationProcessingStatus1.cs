// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information of a standing instruction cancellation request.
/// </summary>
[IsoId("_Rk6tYdp-Ed-ak6NoX_4Aeg_-1104222810")]
[DisplayName("Corporate Action Standing Instruction Cancellation Processing Status")]
public record CorporateActionStandingInstructionCancellationProcessingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_Rk6tYtp-Ed-ak6NoX_4Aeg_1118099245")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus4FormatChoice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rk6tY9p-Ed-ak6NoX_4Aeg_1118099524")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
