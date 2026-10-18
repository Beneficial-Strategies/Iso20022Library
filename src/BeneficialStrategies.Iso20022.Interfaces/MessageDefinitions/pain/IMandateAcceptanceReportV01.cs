// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAcceptanceReport message is sent from the agent of the receiver (debtor or creditor) of the MandateRequest message (initiation, amendment or cancellation) to the agent of the initiator of the MandateRequest message (debtor or creditor).
/// A MandateAcceptanceReport message is used to confirm the acceptance or rejection of a MandateRequest message. |Where acceptance is part of the full process flow, a MandateRequest message only becomes valid after a confirmation of acceptance is received through a MandateAcceptanceReport message from the agent of the receiver.
/// Usage
/// The MandateAcceptanceReport message can contain only one confirmation of acceptance of rejection of one specific MandateRequest message.
/// The messages can be exchanged between debtor agent and creditor agent and between debtor agent and debtor and creditor agent and creditor.
/// The MandateAcceptanceReport message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_GX7CUtEvEd-BzquC8wXy7w_2092980503")]
public interface IMandateAcceptanceReportV01 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate acceptance, but which are not part of the mandate.
    /// </summary>
    [IsoId("_GX7CU9EvEd-BzquC8wXy7w_-1730068754")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader31 GroupHeader { get; }

    /// <summary>
    /// Set of elements used to provide information on the acception or rejection of the mandate request.
    /// </summary>
    [IsoId("_GX7CVNEvEd-BzquC8wXy7w_1787356156")]
    [DisplayName("Underlying Acceptance Details")]
    [IsoXmlTag("UndrlygAccptncDtls")]
    IMandateAcceptance1 UnderlyingAcceptanceDetails { get; }
}
