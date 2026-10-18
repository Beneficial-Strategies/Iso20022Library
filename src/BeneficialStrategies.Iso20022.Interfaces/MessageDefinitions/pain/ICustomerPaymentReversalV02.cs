// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CustomerPaymentReversal message is sent by the initiating party to the next party in the payment chain. It is used to reverse a payment previously executed.
/// Usage
/// The CustomerPaymentReversal message is exchanged between a non-financial institution customer and an agent to reverse a CustomerDirectDebitInitiation message that has been settled. The result will be a credit on the debtor account.
/// The CustomerPaymentReversal message refers to the original CustomerDirectDebitInitiation message by means of references only or by means of references and a set of elements from the original instruction.
/// The CustomerPaymentReversal message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_GXLbgtEvEd-BzquC8wXy7w_66905835")]
public interface ICustomerPaymentReversalV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_GXUlYNEvEd-BzquC8wXy7w_67825938")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader40 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_GXUlYdEvEd-BzquC8wXy7w_67826083")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation22 OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original payment information, to which the reversal message refers.
    /// </summary>
    [IsoId("_GXUlYtEvEd-BzquC8wXy7w_-1091943635")]
    [DisplayName("Original Payment Information And Reversal")]
    [IsoXmlTag("OrgnlPmtInfAndRvsl")]
    IOriginalPaymentInformation2? OriginalPaymentInformationAndReversal { get; }
}
