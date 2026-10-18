// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details specific to the individual settlement instruction(s) included in the message.
/// </summary>
[IsoId("_z-2GQTEyEe6g-ffJsqGiSA")]
public interface IMultilateralSettlementRequest3 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the instruction.
    /// </summary>
    /// <remarks>
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </remarks>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    IsoMax35Text InstructionIdentification { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the instruction.
    /// </summary>
    /// <remarks>
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as 'Normal'.
    /// </remarks>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    Priority3Code? InstructionPriority { get; }

    /// <summary>
    /// Credit or debit transaction contained in an individual settlement request.
    /// </summary>
    /// <remarks>
    /// Usage: The sum of all amounts (debit and credit records) should net to zero where net settlement is used.
    /// </remarks>
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    IEnumerable<IMovementRecord2> MovementRecord { get; }

    /// <summary>
    /// Indicator of the number of movement records contained in an individual settlement request.
    /// </summary>
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    IsoNumber? NumberOfMovementRecords { get; }

    /// <summary>
    /// Identification of the settlement cycle in the settlement service.
    /// </summary>
    /// <remarks>
    /// Usage: The SettlementCycle is used to differentiate this multilateral settlement from other multilateral settlements where more than one occurs within a given time period.
    /// </remarks>
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    IsoMax35Text? SettlementCycle { get; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the settlement instruction.
    /// </summary>
    /// <remarks>
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as 'Normal'.
    /// </remarks>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    Priority3Code? SettlementPriority { get; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the instruction.
    /// </summary>
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    ISettlementTimeRequest2? SettlementTimeRequest { get; }
}
