// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.pacs;

/// <summary>
/// This record is an implementation of the pacs.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MultilateralSettlementRequest message is sent from an instructing agent to a market infrastructure to settle obligations between their participants using accounts held in a settlement service.
///
/// Usage: The MultilateralSettlementRequest message can contain one or more settlement instructions with multiple movements between accounts. By default, all movements present in an individual instruction shall be processed as a batch entry rather than a single entry per individual movement.
/// </summary>
[IsoId("_vsvOgQcYEeyTDbUIoCmuCw")]
public interface IMultilateralSettlementRequestV01 : IOuterRecord
{
    /// <summary>
    /// Set of characteristics shared by all individual instructions included in the message.
    /// </summary>
    [IsoId("_vsvOgwcYEeyTDbUIoCmuCw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    IGroupHeader104 GroupHeader { get; }

    /// <summary>
    /// Set of elements providing information specific to the individual settlement request(s).
    /// </summary>
    [IsoId("_vsvOhQcYEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Request")]
    [IsoXmlTag("SttlmReq")]
    IEnumerable<IMultilateralSettlementRequest2> SettlementRequest { get; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_vsvOhwcYEeyTDbUIoCmuCw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    ISupplementaryData1? SupplementaryData { get; }
}
