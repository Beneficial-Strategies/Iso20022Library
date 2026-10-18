// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be cancelled.
/// </summary>
[IsoId("_dBASSUjwEeaVLL5QKJ4f-A")]
public interface IMandateCancellation5 : IIsoComponent
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_dJ36Q0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Message Information")]
    [IsoXmlTag("OrgnlMsgInf")]
    IOriginalMessageInformation1? OriginalMessageInformation { get; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_dJ36RUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    IPaymentCancellationReason1 CancellationReason { get; }

    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    [IsoId("_dJ36R0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    IOriginalMandate4Choice OriginalMandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dJ36SUjwEeaVLL5QKJ4f-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
