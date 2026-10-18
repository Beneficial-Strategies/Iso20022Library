// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mandate Cancellation8.
/// </summary>
[IsoId("_5ukCITEyEe6g-ffJsqGiSA")]
public interface IMandateCancellation8 : IIsoComponent
{
    /// <summary>
    /// Cancellation Reason.
    /// </summary>
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    IMandateCancellationReason2 CancellationReason { get; }

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
