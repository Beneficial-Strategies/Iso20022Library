// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The FIToFIPaymentReversal message is exchanged between agents to reverse a FIToFICustomerDirectDebit message that has been settled. The result will be a credit on the debtor account.
/// The FIToFIPaymentReversal message may or may not be the follow-up of a CustomerDirectDebitInitiation message.
/// The FIToFIPaymentReversal message refers to the original FIToFICustomerDirectDebit message by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.
///
/// </summary>
[IsoId("_elKe5dEuEd-BzquC8wXy7w_-1796587382")]
public interface IFIToFIPaymentReversalV01 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_elKe5tEuEd-BzquC8wXy7w_421348727")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader9 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_elKe59EuEd-BzquC8wXy7w_357436312")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation5 OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_elKe6NEuEd-BzquC8wXy7w_-191011416")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IPaymentTransactionInformation5? TransactionInformation { get; }
}
