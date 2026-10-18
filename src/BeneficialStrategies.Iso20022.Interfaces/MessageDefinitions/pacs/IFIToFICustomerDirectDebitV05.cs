// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.003.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The FinancialInstitutionToFinancialInstitutionCustomerDirectDebit message is sent by the creditor agent to the debtor agent, directly or through other agents and/or a payment clearing and settlement system.
/// It is used to collect funds from a debtor account for a creditor.
/// Usage
/// The FItoFICustomerDirectDebit message can contain one or more customer direct debit instructions.
/// The FIToFICustomerDirectDebit message does not allow for grouping: the PaymentInformation block must be present once per occurrence of a DirectDebitTransactionInformation block.
/// The FItoFICustomerDirectDebit message may or may not contain mandate related information, i.e. extracts from a mandate, such as the MandateIdentification or DateOfSignature. The FIToFICustomerDirectDebit message must not be considered as a mandate.
/// The FItoFICustomerDirectDebit message can be used in domestic and cross-border scenarios.
/// </summary>
[IsoId("_fTgL6xPeEeSVo-TFVwFHvA")]
public interface IFIToFICustomerDirectDebitV05 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_fTgL_RPeEeSVo-TFVwFHvA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader50 GroupHeader { get; }

    /// <summary>
    /// Set of elements providing information specific to the individual direct debit(s).
    /// </summary>
    [IsoId("_fTgL_xPeEeSVo-TFVwFHvA")]
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    IEnumerable<IDirectDebitTransactionInformation17> DirectDebitTransactionInformation { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fTgMARPeEeSVo-TFVwFHvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
