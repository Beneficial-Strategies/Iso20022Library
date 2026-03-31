// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Suspension4.
/// </summary>
[IsoId("_4Q5KQTEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Suspension4")]
public record MandateSuspension4
{
    /// <summary>
    /// Original Mandate.
    /// </summary>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public required OriginalMandate10Choice_ OriginalMandate { get; init; }

    /// <summary>
    /// Original Message Information.
    /// </summary>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Suspension Reason.
    /// </summary>
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    public required MandateSuspensionReason3 SuspensionReason { get; init; }

    /// <summary>
    /// Suspension Request Identification.
    /// </summary>
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    public required IsoMax35Text SuspensionRequestIdentification { get; init; }
}
