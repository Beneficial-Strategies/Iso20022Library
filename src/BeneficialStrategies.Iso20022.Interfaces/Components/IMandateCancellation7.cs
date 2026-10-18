// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
[IsoId("_f5VZ8dcZEeqRFcf2R4bPBw")]
public interface IMandateCancellation7 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_f7c50dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_f7c509cZEeqRFcf2R4bPBw")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    IMandateCancellationReason1 CancellationReason { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_f7c51dcZEeqRFcf2R4bPBw")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate9Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_f7c519cZEeqRFcf2R4bPBw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
