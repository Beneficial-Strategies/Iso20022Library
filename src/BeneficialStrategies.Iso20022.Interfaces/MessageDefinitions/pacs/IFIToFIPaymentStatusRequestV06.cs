// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.028.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3Lm2zEZEe6kQ-WGAhcVPQ")]
public interface IFIToFIPaymentStatusRequestV06 : IOuterRecord
{
    /// <summary>
    /// Group Header.
    /// </summary>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader109 GroupHeader { get; }

    /// <summary>
    /// Original Group Information.
    /// </summary>
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    IEnumerable<IOriginalGroupInformation27> OriginalGroupInformation { get; }

    /// <summary>
    /// Transaction Information.
    /// </summary>
    [DisplayName("Transaction Information")]
    [IsoXmlTag("TxInf")]
    IEnumerable<IPaymentTransaction158> TransactionInformation { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
