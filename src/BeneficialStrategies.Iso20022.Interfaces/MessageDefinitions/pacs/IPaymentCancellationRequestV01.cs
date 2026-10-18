// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentCancellationRequest message is sent by the initiating party or any agent, to the next party in the payment chain. It is used to request the cancellation of an instruction previously sent.
/// Usage
/// The PaymentCancellationRequest message is exchanged between agents to request the cancellation of a payment message previously sent (i.e. FIToFICustomerCreditTransfer, FIToFICustomerDirectDebit, and FinancialInstitutionCreditTransfer).
/// The PaymentCancellationRequest message can be used to request the cancellation of single instructions or multiple instructions, from one or multiple files.
/// The PaymentCancellationRequest message can be used in domestic and cross-border scenarios.
/// The PaymentCancellationRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The PaymentCancellationRequest message exchanged between agents is identified in the schema as follows: |urn: iso: std: iso: 20022: tech: xsd: pacs.006.001.01|.
/// </summary>
[IsoId("_eoSrcdEuEd-BzquC8wXy7w_-1218856998")]
public interface IPaymentCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_eoccYNEuEd-BzquC8wXy7w_-45030390")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader7 GroupHeader { get; }

    /// <summary>
    /// Information concerning the original group of transactions, to which the message refers.
    /// </summary>
    [IsoId("_eoccYdEuEd-BzquC8wXy7w_1160897113")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation4 OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the cancellation request message refers.
    /// </summary>
    [IsoId("_eoccYtEuEd-BzquC8wXy7w_1545316731")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IEnumerable<IPaymentTransactionInformation3> TransactionInformation { get; }
}
