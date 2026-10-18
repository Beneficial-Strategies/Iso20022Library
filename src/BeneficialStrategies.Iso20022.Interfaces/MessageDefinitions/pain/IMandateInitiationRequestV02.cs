// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.009.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateInitiationRequest message is sent by the initiator of the request to his agent. The initiator can either be the debtor or the creditor.
/// The MandateInitiationRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// The MandateInitiationRequest message is used to set-up the instruction that allows the debtor agent to accept instructions from the creditor, through the creditor agent, to debit the account of the debtor.
/// Usage
/// The MandateInitiationRequest message can contain only one request to set-up one specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateInitiationRequest message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_r1UQkFkyEeGeoaLUQk__nA_-422128939")]
public interface IMandateInitiationRequestV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the mandate initiation, but which are not part of the mandate.
    /// </summary>
    [IsoId("_r1eBkFkyEeGeoaLUQk__nA_-783756144")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader47 GroupHeader { get; }

    /// <summary>
    /// Set of elements used to provide the details of the mandate signed between the (ultimate) creditor and the (ultimate) debtor.
    /// </summary>
    [IsoId("_r1nLgFkyEeGeoaLUQk__nA_-1666989431")]
    [DisplayName("Mandate")]
    [IsoXmlTag("Mndt")]
    IMandate2 Mandate { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_r1w8gFkyEeGeoaLUQk__nA_-1209081288")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
