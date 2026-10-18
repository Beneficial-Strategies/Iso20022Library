// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.017.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateCopyRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateCopyRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateCopyRequest message is used to request a copy of an existing mandate. If accepted, the mandate copy can be sent using the MandateAcceptanceReport message.
/// Usage
/// The MandateCopyRequest message can contain one or more copy requests.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateCopyRequest message can be used in domestic and cross-border scenarios.
///
/// </summary>
[IsoId("_rUYOHdcBEeq_l4BJLVUF2Q")]
public interface IMandateCopyRequestV03 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate copy request, but which are not part of the mandate.
    /// </summary>
    [IsoId("_rUYOJ9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader80 GroupHeader { get; }

    /// <summary>
    /// Set of information used to identify the mandate for which a copy is requested.
    /// </summary>
    [IsoId("_rUYOKdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Underlying Copy Request Details")]
    [IsoXmlTag("UndrlygCpyReqDtls")]
    IMandateCopy3 UnderlyingCopyRequestDetails { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rUYOK9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
