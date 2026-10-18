// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.007.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The FIToFIPaymentReversal message is exchanged between agents to reverse a payment message that has been settled. The result will be a credit on the debtor account (when the reversed payment was a direct debit) or a debit on the creditor account (when the reversed payment was a credit transfer).
/// The FIToFIPaymentReversal message may or may not be the follow-up of a payment message.
/// The FIToFIPaymentReversal message refers to the original payment message by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_x0JYo3L4EeidQ_AAdEzxQA")]
public interface IFIToFIPaymentReversalV09 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_x0JYv3L4EeidQ_AAdEzxQA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader89 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_x0JYwXL4EeidQ_AAdEzxQA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupHeader16? OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_x0JYw3L4EeidQ_AAdEzxQA")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IPaymentTransaction111? TransactionInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_x0JYxXL4EeidQ_AAdEzxQA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
