// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerCreditTransferInitiation message is sent by the initiating party to the forwarding agent or debtor agent. It is used to request movement of funds from the debtor account to a creditor.
/// Usage
/// The CustomerCreditTransferInitiation message can contain one or more customer credit transfer instructions.
/// The CustomerCreditTransferInitiation message is used to exchange:
/// - One or more instances of a credit transfer initiation;
/// - Payment transactions that result in book transfers at the debtor agent or payments to another financial institution;
/// - Payment transactions that result in an electronic cash transfer to the creditor account or in the emission of a cheque.
/// The message can be used in a direct or a relay scenario:
/// - In a direct scenario, the message is sent directly to the debtor agent. The debtor agent is the account servicer of the debtor.
/// - In a relay scenario, the message is sent to a forwarding agent. The forwarding agent acts as a concentrating financial institution. It will forward the CustomerCreditTransferInitiation message to the debtor agent.
/// The message can also be used by an initiating party that has authority to send the message on behalf of the debtor. This caters for example for the scenario of a payments factory initiating all payments on behalf of a large corporate.
/// The CustomerCreditTransferInitiation message can be used in domestic and cross-border scenarios.
/// The CustomerCreditTransferInitiation message must not be used by the debtor agent to execute the credit transfer instruction(s). The FIToFICustomerCreditTransfer message must be used instead.
/// </summary>
[IsoId("_r-Z7IFkyEeGeoaLUQk__nA_834448268")]
public interface ICustomerCreditTransferInitiationV04 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_r-Z7IVkyEeGeoaLUQk__nA_1733001591")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader48 GroupHeader { get; }

    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the credit transfer initiation.
    /// </summary>
    [IsoId("_r-Z7IlkyEeGeoaLUQk__nA_849768304")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    IPaymentInstruction6 PaymentInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_r-jsIFkyEeGeoaLUQk__nA_-1120888027")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
