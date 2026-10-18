// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.003.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3JxzzEZEe6kQ-WGAhcVPQ")]
public interface IFIToFICustomerDirectDebitV11 : IOuterRecord
{
    /// <summary>
    /// Group Header.
    /// </summary>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader125 GroupHeader { get; }

    /// <summary>
    /// Direct Debit Transaction Information.
    /// </summary>
    [DisplayName("Direct Debit Transaction Information")]
    [IsoXmlTag("DrctDbtTxInf")]
    IEnumerable<IDirectDebitTransactionInformation31> DirectDebitTransactionInformation { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
