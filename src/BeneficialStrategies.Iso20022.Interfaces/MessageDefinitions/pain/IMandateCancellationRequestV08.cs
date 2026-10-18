// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pain;

/// <summary>
/// This record is an implementation of the pain.011.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3P4XzEZEe6kQ-WGAhcVPQ")]
public interface IMandateCancellationRequestV08 : IOuterRecord
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
    /// Underlying Cancellation Details.
    /// </summary>
    [DisplayName("Underlying Cancellation Details")]
    [IsoXmlTag("UndrlygCxlDtls")]
    IEnumerable<IMandateCancellation8> UnderlyingCancellationDetails { get; }
}
