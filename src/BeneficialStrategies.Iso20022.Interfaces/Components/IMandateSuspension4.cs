// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Suspension4.
/// </summary>
[IsoId("_4Q5KQTEyEe6g-ffJsqGiSA")]
public interface IMandateSuspension4 : IIsoComponent
{
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

    /// <summary>
    /// Suspension Reason.
    /// </summary>
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    IMandateSuspensionReason3 SuspensionReason { get; }

    /// <summary>
    /// Suspension Request Identification.
    /// </summary>
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    IsoMax35Text SuspensionRequestIdentification { get; }
}
