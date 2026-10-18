// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentCancellationRequest message is sent by the initiating party or any agent, to the next party in the payment chain. It is used to request the cancellation of an instruction previously sent.
/// Usage
/// The PaymentCancellationRequest message is exchanged between non-financial institution customers and agents to request the cancellation of a payment initiation message previously sent (i.e. the CustomerCreditTransferInitiation message and the CustomerDirectDebitInitiation messages).
/// The PaymentCancellationRequest message can be used to request the cancellation of single instructions or multiple instructions, from one or multiple files.
/// The PaymentCancellationRequest message can be used in domestic and cross-border scenarios.
/// The PaymentCancellationRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The PaymentCancellationRequest message exchanged between non-financial institution customers and agents is identified in the schema as follows: urn:iso:std:iso:20022:tech:xsd:pain.006.001.01.
/// </summary>
[IsoId("_GZHVINEvEd-BzquC8wXy7w_162316323")]
public interface IPaymentCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_GZQfENEvEd-BzquC8wXy7w_162316362")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader7 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_GZQfEdEvEd-BzquC8wXy7w_162316385")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation4 OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_GZQfEtEvEd-BzquC8wXy7w_162316416")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IPaymentTransactionInformation3? TransactionInformation { get; }
}
