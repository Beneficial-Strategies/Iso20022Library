// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate, which is being suspended.
/// </summary>
[IsoId("_SaI98W49EeiU9cctagi5ow")]
public interface IMandateSuspension2 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the suspension request.
    /// </summary>
    [IsoId("_Sk3nQW49EeiU9cctagi5ow")]
    [DisplayName("Suspension Request Identification")]
    [IsoXmlTag("SspnsnReqId")]
    IsoMax35Text SuspensionRequestIdentification { get; }

    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_Sk3nQ249EeiU9cctagi5ow")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the suspension reason.
    /// </summary>
    [IsoId("_Sk3nRW49EeiU9cctagi5ow")]
    [DisplayName("Suspension Reason")]
    [IsoXmlTag("SspnsnRsn")]
    IMandateSuspensionReason2 SuspensionReason { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_Sk3nR249EeiU9cctagi5ow")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate6Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Sk3nSW49EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
