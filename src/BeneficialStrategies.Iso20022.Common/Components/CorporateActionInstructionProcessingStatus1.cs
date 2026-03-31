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
[IsoId("_Rknyd9p-Ed-ak6NoX_4Aeg_-1100180300")]
[DisplayName("Corporate Action Instruction Processing Status")]
public record CorporateActionInstructionProcessingStatus1
{
    /// <summary>
    /// The processing status.
    /// </summary>
    [IsoId("_RknyeNp-Ed-ak6NoX_4Aeg_-1029069131")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ProcessedStatus3FormatChoice_ Status { get; init; }

    /// <summary>
    /// Additional information about the status.
    /// </summary>
    [IsoId("_Rkw8YNp-Ed-ak6NoX_4Aeg_-744625301")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; }
}
