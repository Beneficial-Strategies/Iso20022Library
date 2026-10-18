// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentStatusReport message is sent by an instructed agent to the previous party in the payment chain. It is used to inform this party about the positive or negative status of an instruction (either single or file). It is also used to report on a pending instruction.
/// Usage
/// The FIToFIPaymentStatusReport message is exchanged between agents to provide status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.
/// The FIToFIPaymentStatusReport message can be used to provide information about the status (e.g. rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).
/// The FIToFIPaymentStatusReport message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentStatusReport message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_elwU0dEuEd-BzquC8wXy7w_-718126476")]
public interface IFIToFIPaymentStatusReportV03 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status report message.
    /// </summary>
    [IsoId("_elwU0tEuEd-BzquC8wXy7w_-717206472")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader37 GroupHeader { get; }

    /// <summary>
    /// Original group information concerning the group of transactions, to which the status report message refers to.
    /// </summary>
    [IsoId("_elwU09EuEd-BzquC8wXy7w_-717206380")]
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    IOriginalGroupInformation20 OriginalGroupInformationAndStatus { get; }

    /// <summary>
    /// Information concerning the original transactions, to which the status report message refers.
    /// </summary>
    [IsoId("_el6FwNEuEd-BzquC8wXy7w_-717206288")]
    [DisplayName("Transaction Information And Status")]
    [IsoXmlTag("TxInfAndSts")]
    IEnumerable<IPaymentTransactionInformation26> TransactionInformationAndStatus { get; }
}
