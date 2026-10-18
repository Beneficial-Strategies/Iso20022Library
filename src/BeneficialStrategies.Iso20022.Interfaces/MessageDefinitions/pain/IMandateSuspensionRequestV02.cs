// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.018.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateSuspensionRequest message is sent by the initiator of the request to its agent. The initiator can either be the debtor, debtor agent, creditor or creditor agent.
/// A MandateSuspensionRequest message is used to request the suspension of an existing mandate until the suspension is lifted.
/// Usage
/// The MandateSuspensionRequest message can contain one or more suspension requests.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The MandateSuspensionRequest message can be used in domestic and cross-border scenarios.
///
/// </summary>
[IsoId("_bf9SRW2PEei3KuUgpx7Xcw")]
public interface IMandateSuspensionRequestV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate suspension request, but which are not part of the mandate.
    /// </summary>
    [IsoId("_bf9SSW2PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader80 GroupHeader { get; }

    /// <summary>
    /// Set of elements used to provide information on the suspension request of the mandate.
    /// </summary>
    [IsoId("_bf9SS22PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying Suspension Details")]
    [IsoXmlTag("UndrlygSspnsnDtls")]
    IMandateSuspension2 UnderlyingSuspensionDetails { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9STW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
