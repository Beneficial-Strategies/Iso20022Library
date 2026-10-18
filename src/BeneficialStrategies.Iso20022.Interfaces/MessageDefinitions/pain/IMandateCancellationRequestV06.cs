// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.011.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateCancellationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateCancellationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateCancellationRequest message is used to request the cancellation of an existing mandate. If accepted, this MandateCancellationRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered a valid cancellation of an existing mandate, agreed upon by all parties.
/// Usage
/// The MandateCancellationRequest message can contain one or more request(s) to cancel a specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateCancellationRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_bf9SJ22PEei3KuUgpx7Xcw")]
public interface IMandateCancellationRequestV06 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the cancellation of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_bf9SK22PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader80 GroupHeader { get; }

    /// <summary>
    /// Set of elements used to provide details on the cancellation request.
    /// </summary>
    [IsoId("_bf9SLW2PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying Cancellation Details")]
    [IsoXmlTag("UndrlygCxlDtls")]
    IMandateCancellation6 UnderlyingCancellationDetails { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9SL22PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
