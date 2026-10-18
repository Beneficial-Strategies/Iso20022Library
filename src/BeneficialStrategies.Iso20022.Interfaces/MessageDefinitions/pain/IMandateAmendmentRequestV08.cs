// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.010.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3P4TzEZEe6kQ-WGAhcVPQ")]
public interface IMandateAmendmentRequestV08 : IOuterRecord
{
    /// <summary>
    /// Group Header.
    /// </summary>
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader110 GroupHeader { get; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    IEnumerable<ISupplementaryData1> SupplementaryData { get; }

    /// <summary>
    /// Underlying Amendment Details.
    /// </summary>
    [DisplayName("Underlying Amendment Details")]
    [IsoXmlTag("UndrlygAmdmntDtls")]
    IEnumerable<IMandateAmendment8> UnderlyingAmendmentDetails { get; }
}
