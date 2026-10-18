// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.010.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstitutionDirectDebit message is sent by an exchange or clearing house, or a financial institution, directly or through another agent, to the DebtorAgent. It is used to instruct the DebtorAgent to move funds from one or more debtor(s) account(s) to one or more creditor(s), where both debtor and creditor are financial institutions.
/// </summary>
/// <remarks>
/// Usage
/// The FinancialInstitutionDirectDebit message is exchanged between agents and can contain one or more financial institution direct debit instruction(s) for one or more creditor(s). The FinancialInstitutionDirectDebit message can be used in domestic and cross-border scenarios.
/// </remarks>
[IsoId("_R3LnHzEZEe6kQ-WGAhcVPQ")]
public interface IFinancialInstitutionDirectDebitV06 : IOuterRecord
{
    /// <summary>
    /// Common characteristics for all individual transactions included in the message.
    /// </summary>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader119 GroupHeader { get; }

    /// <summary>
    /// Characteristics that apply to the credit side of the payment transaction(s) included in the message.
    /// </summary>
    [DisplayName("Credit Instruction")]
    [IsoXmlTag("CdtInstr")]
    IEnumerable<ICreditTransferTransaction66> CreditInstruction { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
