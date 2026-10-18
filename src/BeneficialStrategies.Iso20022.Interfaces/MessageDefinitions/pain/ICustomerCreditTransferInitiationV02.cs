// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.001.001.02 ISO standard message type.
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
/// If it is agreed to include the payment information related to the debit side only once (i.e. Grouped mode), the PaymentInformation block will be present only once.
/// If it is agreed to repeat the payment information related to the debit side (i.e. Single mode), the PaymentInformation block must be present once per occurrence of the CreditTransferTransactionInformation block.
/// The CustomerCreditTransferInitiation message also allows for a Mixed mode where the PaymentInformation block can be repeated and each PaymentInformation block can contain one or several CreditTransferTransactionInformation block(s).|Single|When grouping is set to Single, information for each individual instruction is included separately. This means the|PaymentInformation block is repeated, and present for each occurrence of the CreditTransferTransactionInformation block.|Grouped|When grouping is set to Grouped, the PaymentInformation block will be present once and the CreditTransferTransactionInformation block will be repeated.|Mixed|When grouping is set to Mixed, the PaymentInformation block may be present once or may be repeated. Each sequence|of the PaymentInformation block may contain one or several CreditTransferTransactionInformation block(s).
/// </summary>
[IsoId("_GWb0ldEvEd-BzquC8wXy7w_1535349168")]
public interface ICustomerCreditTransferInitiationV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_GWb0ltEvEd-BzquC8wXy7w_1535349187")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader1 GroupHeader { get; }

    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the credit transfer initiation.
    /// </summary>
    [IsoId("_GWb0l9EvEd-BzquC8wXy7w_1536269287")]
    [DisplayName("Payment Information")]
    [IsoXmlTag("PmtInf")]
    IPaymentInstructionInformation1 PaymentInformation { get; }
}
