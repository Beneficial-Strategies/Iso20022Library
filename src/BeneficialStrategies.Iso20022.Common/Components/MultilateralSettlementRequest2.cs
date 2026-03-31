// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details specific to the individual settlement instruction(s) included in the message.
/// </summary>
[IsoId("_I5-6EQcZEeyTDbUIoCmuCw")]
[DisplayName("Multilateral Settlement Request")]
public record MultilateralSettlementRequest2
{
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the instruction.
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_I-zvsQcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the instruction.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as &apos;Normal&apos;.
    /// </summary>
    [IsoId("_I-zvswcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority3Code? InstructionPriority { get; init; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the instruction.
    /// </summary>
    [IsoId("_I-zvtwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the settlement instruction.
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as &apos;Normal&apos;.
    /// </summary>
    [IsoId("_I-zvuQcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Identification of the settlement cycle in the settlement service.
    /// Usage: The SettlementCycle is used to differentiate this multilateral settlement from other multilateral settlements where more than one occurs within a given time period.
    /// </summary>
    [IsoId("_I-zvuwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SettlementCycle { get; init; }

    /// <summary>
    /// Indicator of the number of movement records contained in an individual settlement request.
    /// </summary>
    [IsoId("_I-zvvQcZEeyTDbUIoCmuCw")]
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMovementRecords { get; init; }

    /// <summary>
    /// Credit or debit transaction contained in an individual settlement request.
    /// Usage: Number of occurrences of MovementRecord shall always be even.
    /// </summary>
    [IsoId("_I-zvvwcZEeyTDbUIoCmuCw")]
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    public ValueList<MovementRecord1> MovementRecord { get; init; } = [];
    // ID for the above is _I-zvvwcZEeyTDbUIoCmuCw
}
