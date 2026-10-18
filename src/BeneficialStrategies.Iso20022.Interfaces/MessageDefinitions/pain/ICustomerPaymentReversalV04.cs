// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.007.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.
/// The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_Z15XoSGmEeKjd4jizyIDGA")]
public interface ICustomerPaymentReversalV04 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_Z15XsyGmEeKjd4jizyIDGA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader56 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_Z15XtyGmEeKjd4jizyIDGA")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupHeader3 OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original payment information, to which the reversal message refers.
    /// </summary>
    [IsoId("_Z15XuyGmEeKjd4jizyIDGA")]
    [DisplayName("Original Payment Information And Reversal")]
    [IsoXmlTag("OrgnlPmtInfAndRvsl")]
    IOriginalPaymentInstruction7? OriginalPaymentInformationAndReversal { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Z15XwyGmEeKjd4jizyIDGA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
