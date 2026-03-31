// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Amendment8.
/// </summary>
[IsoId("_yLKiITEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Amendment8")]
public record MandateAmendment8
{
    /// <summary>
    /// Amendment Reason.
    /// </summary>
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    public required MandateAmendmentReason3 AmendmentReason { get; init; }

    /// <summary>
    /// Mandate.
    /// </summary>
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    public required Mandate21 Mandate { get; init; }

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
}
