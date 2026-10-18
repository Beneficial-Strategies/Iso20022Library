// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details specific to the individual settlement instruction(s) included in the message.
/// </summary>
[IsoId("_I5-6EQcZEeyTDbUIoCmuCw")]
public interface IMultilateralSettlementRequest2 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_I-zvsQcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    IsoMax35Text InstructionIdentification { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the instruction.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as &apos;Normal&apos;.
    /// </summary>
    [IsoId("_I-zvswcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority3Code? InstructionPriority { get; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the instruction.
    /// </summary>
    [IsoId("_I-zvtwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the settlement instruction.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as &apos;Normal&apos;.
    /// </summary>
    [IsoId("_I-zvuQcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Identification of the settlement cycle in the settlement service.
    /// Usage: The SettlementCycle is used to differentiate this multilateral settlement from other multilateral settlements where more than one occurs within a given time period.
    /// </summary>
    [IsoId("_I-zvuwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    IsoMax35Text? SettlementCycle { get; }

    /// <summary>
    /// Indicator of the number of movement records contained in an individual settlement request.
    /// </summary>
    [IsoId("_I-zvvQcZEeyTDbUIoCmuCw")]
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    IsoNumber? NumberOfMovementRecords { get; }

    /// <summary>
    /// Credit or debit transaction contained in an individual settlement request.
    /// Usage: Number of occurrences of MovementRecord shall always be even.
    /// </summary>
    [IsoId("_I-zvvwcZEeyTDbUIoCmuCw")]
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    IEnumerable<IMovementRecord1> MovementRecord { get; }
}
