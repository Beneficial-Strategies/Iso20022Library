// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.002.001.14 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3H8fTEZEe6kQ-WGAhcVPQ")]
public interface ICustomerPaymentStatusReportV14 : IOuterRecord
{
    /// <summary>
    /// Group Header.
    /// </summary>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader128 GroupHeader { get; }

    /// <summary>
    /// Original Group Information And Status.
    /// </summary>
    [DisplayName("Original Group Information And Status")]
    [IsoXmlTag("OrgnlGrpInfAndSts")]
    IOriginalGroupHeader22 OriginalGroupInformationAndStatus { get; }

    /// <summary>
    /// Original Payment Information And Status.
    /// </summary>
    [DisplayName("Original Payment Information And Status")]
    [IsoXmlTag("OrgnlPmtInfAndSts")]
    IEnumerable<IOriginalPaymentInstruction51> OriginalPaymentInformationAndStatus { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }
}
