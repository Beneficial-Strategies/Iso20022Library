// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The PaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.
/// Usage
/// The PaymentStatusReport message is exchanged between agents to provide status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.
/// The PaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (e.g. PaymentCancellationRequest).
/// The PaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The PaymentStatusReport message can be used in domestic and cross-border scenarios.
/// The PaymentStatusReport message exchanged between agents is identified in the schema as follows: |urn:iso:std:iso:20022:tech:xsd:pacs.002.001.02|.
/// </summary>
[IsoId("_esBU4dEuEd-BzquC8wXy7w_-2138292511")]
public interface IPaymentStatusReportV02 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_esKewNEuEd-BzquC8wXy7w_727956740")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader5 GroupHeader { get; }

    /// <summary>
    /// Original group information concerning the group of transactions, to which the message refers to.
    /// </summary>
    [IsoId("_esKewdEuEd-BzquC8wXy7w_33992")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    IOriginalGroupInformation1 OriginalGroupInformationAndStatus { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the status report message refers.
    /// </summary>
    [IsoId("_esKewtEuEd-BzquC8wXy7w_-920593119")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransactionInformation1> TransactionInformationAndStatus { get; }
}
