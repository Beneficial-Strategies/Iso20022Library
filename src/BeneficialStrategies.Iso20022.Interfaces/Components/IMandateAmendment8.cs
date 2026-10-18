// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
[IsoId("_yLKiITEyEe6g-ffJsqGiSA")]
public interface IMandateAmendment8 : IIsoComponent
{
    /// <summary>
    /// Amendment Reason.
    /// </summary>
    [DisplayName("Amendment Reason")]
    [IsoXmlTag("AmdmntRsn")]
    IMandateAmendmentReason3 AmendmentReason { get; }

    /// <summary>
    /// Mandate.
    /// </summary>
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    IMandate21 Mandate { get; }

    /// <summary>
    /// Original Mandate.
    /// </summary>
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate10Choice OriginalMandate { get; }

    /// <summary>
    /// Original Message Information.
    /// </summary>
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
