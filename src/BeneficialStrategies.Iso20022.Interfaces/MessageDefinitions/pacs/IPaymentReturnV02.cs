// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentReturn message is sent by an agent to the previous agent in the payment chain to undo a payment previously settled.
/// Usage
/// The PaymentReturn message is exchanged between agents to return funds after settlement of credit transfer instructions (i.e. FIToFICustomerCreditTransfer message and FinancialInstitutionCreditTransfer message) or direct debit instructions (FIToFICustomerDirectDebit message).
/// The PaymentReturn message should not be used between agents and non-financial institution customers. Non-financial institution customers will be informed about a debit or a credit on their account(s) through a BankToCustomerDebitCreditNotification message (&apos;notification&apos;) and/or BankToCustomerAccountReport/BankToCustomerStatement message (&apos;statement&apos;).
/// The PaymentReturn message can be used to return single instructions or multiple instructions from one or different files.
/// The PaymentReturn message can be used in domestic and cross-border scenarios.
/// The PaymentReturn message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// </summary>
[IsoId("_eqYWKtEuEd-BzquC8wXy7w_-993933741")]
public interface IPaymentReturnV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eqhgANEuEd-BzquC8wXy7w_-993933711")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader38 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_eqhgAdEuEd-BzquC8wXy7w_-993933370")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation21? OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the return message refers.
    /// </summary>
    [IsoId("_eqhgAtEuEd-BzquC8wXy7w_-993933649")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IEnumerable<IPaymentTransactionInformation27> TransactionInformation { get; }
}
