// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide processing status information of a standing instruction request.
/// </summary>
[IsoId("_Rk6tZ9p-Ed-ak6NoX_4Aeg_-538958782")]
[DisplayName("Corporate Action Standing Instruction Processing Status")]
public record CorporateActionStandingInstructionProcessingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RlD3UNp-Ed-ak6NoX_4Aeg_-495553264")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus3FormatChoice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_RlD3Udp-Ed-ak6NoX_4Aeg_-495553232")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
