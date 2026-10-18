// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.010.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MandateAmendmentRequest message is sent by the initiator of the request to his agent and/or counterparty. The initiator can both be the debtor or the creditor (or where appropriate the debtor agent).
/// The MandateAmendmentRequest message is forwarded by the agent of the initiator to the agent of the counterparty.
/// A MandateAmendmentRequest message is used to request the amendment of specific information in an existing mandate. The MandateAmendmentRequest message must reflect the new data of the element(s) to be amended and at a minimum a unique reference to the existing mandate. If accepted, this MandateAmendmentRequest message together with the MandateAcceptanceReport message confirming the acceptance will be considered as a valid amendment on an existing mandate, agreed upon by all parties. The amended mandate will from then on be considered the valid mandate.
/// Usage
/// The MandateAmendmentRequest message can contain one or more request(s) to amend a specific mandate.
/// The messages can be exchanged between creditor and creditor agent or debtor and debtor agent and between creditor agent and debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the creditor or debtor.
/// The MandateAmendmentRequest message can be used in domestic and cross-border scenarios.
/// If all elements in the existing Mandate need to be amended or the underlying contract is different, then the MandateAmendmentRequest message should not be used. The existing Mandate has to be cancelled and a new Mandate has to be initiated.
/// </summary>
[IsoId("_bf9SHW2PEei3KuUgpx7Xcw")]
public interface IMandateAmendmentRequestV06 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics to identify the message and parties playing a role in the amendment of the mandate, but which are not part of the mandate.
    /// </summary>
    [IsoId("_bf9SIW2PEei3KuUgpx7Xcw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader80 GroupHeader { get; }

    /// <summary>
    /// Set of elements used to provide details on the amendment request.
    /// </summary>
    [IsoId("_bf9SI22PEei3KuUgpx7Xcw")]
    [DisplayName("Underlying Amendment Details")]
    [IsoXmlTag("UndrlygAmdmntDtls")]
    IMandateAmendment6 UnderlyingAmendmentDetails { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_bf9SJW2PEei3KuUgpx7Xcw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
