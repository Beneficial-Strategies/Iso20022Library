// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.028.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionPaymentStatusRequest message is sent by the debtor agent to the creditor agent, directly or through other agents and/or a payment clearing and settlement system. It is used to request a FIToFIPaymentStatusReport message containing information on the status of a previously sent instruction.
/// Usage
/// The FIToFIPaymentStatusRequest message is exchanged between agents to request status information about instructions previously sent. Its usage will always be governed by a bilateral agreement between the agents.
/// The FIToFIPaymentStatusRequest message can be used to request information about the status (such as rejection, acceptance) of a credit transfer instruction, a direct debit instruction, as well as other intra-agent instructions (for example FIToFIPaymentCancellationRequest).
/// The FIToFIPaymentStatusRequest message refers to the original instruction(s) by means of references only or by means of references and a set of elements from the original instruction.
/// The FIToFIPaymentStatusRequest message can be used in domestic and cross-border scenarios.
///
///
/// </summary>
[IsoId("_jMaBadcBEeq_l4BJLVUF2Q")]
public interface IFIToFIPaymentStatusRequestV05 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the status request message.
    /// </summary>
    [IsoId("_jMaoMdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader91 GroupHeader { get; }

    /// <summary>
    /// Original group information concerning the group of transactions, to which the status request message refers to.
    /// </summary>
    [IsoId("_jMaoM9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IOriginalGroupInformation27? OriginalGroupInformation { get; }

    /// <summary>
    /// Information concerning the original transaction, to which the status request message refers.
    /// </summary>
    [IsoId("_jMaoNdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IPaymentTransaction131? TransactionInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jMaoN9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
