// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.007.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentReversal message is sent by an agent to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The FIToFIPaymentReversal message is exchanged between agents to reverse a payment message that has been settled. The result will be a credit on the debtor account (when the reversed payment was a Direct Debit) or a debit on the creditor account (when the reversed payment was a Credit Transfer).
/// The FIToFIPaymentReversal message may or may not be the follow-up of a payment message.
/// The FIToFIPaymentReversal message refers to the original payment message by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_AOwWeV1tEeehlLdFiIrRgQ")]
public interface IFIToFIPaymentReversalV08 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_AOwWlV1tEeehlLdFiIrRgQ")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader71 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_AOwWl11tEeehlLdFiIrRgQ")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupHeader11? OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the reversal message refers.
    /// </summary>
    [IsoId("_AOwWmV1tEeehlLdFiIrRgQ")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IEnumerable<IPaymentTransaction88> TransactionInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_AOwWm11tEeehlLdFiIrRgQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
