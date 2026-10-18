// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.009.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionCreditTransfer message is sent by a debtor financial institution to a creditor financial institution, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to move funds from a debtor account to a creditor, where both debtor and creditor are financial institutions.
/// Usage
/// The FinancialInstitutionCreditTransfer message is exchanged between agents and can contain one or more credit transfer instructions where debtor and creditor are both financial institutions.
/// The FinancialInstitutionCreditTransfer message does not allow for grouping: a CreditTransferTransactionInformation block must be present for each credit transfer transaction.
/// The FinancialInstitutionCreditTransfer message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_jMaBP9cBEeq_l4BJLVUF2Q")]
public interface IFinancialInstitutionCreditTransferV10 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_jMaBVdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader96 GroupHeader { get; }

    /// <summary>
    /// Set of elements providing information specific to the individual credit transfer(s).
    /// </summary>
    [IsoId("_jMaBV9cBEeq_l4BJLVUF2Q")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    IEnumerable<ICreditTransferTransaction56> CreditTransferTransactionInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jMaBWdcBEeq_l4BJLVUF2Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
