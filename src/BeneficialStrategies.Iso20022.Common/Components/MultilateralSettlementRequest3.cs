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
[Description(@"Provides details specific to the individual settlement instruction(s) included in the message.")]
[IsoId("_z-2GQTEyEe6g-ffJsqGiSA")]
[DisplayName("Multilateral Settlement Request3")]
public record MultilateralSettlementRequest3
{
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the instruction.
    /// </summary>
    /// <remarks>
    /// Usage: The instruction identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </remarks>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the instruction.
    /// </summary>
    /// <remarks>
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as 'Normal'.
    /// </remarks>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority3Code? InstructionPriority { get; init; }

    /// <summary>
    /// Credit or debit transaction contained in an individual settlement request.
    /// </summary>
    /// <remarks>
    /// Usage: The sum of all amounts (debit and credit records) should net to zero where net settlement is used.
    /// </remarks>
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    public ValueList<MovementRecord2> MovementRecord { get; init; } = [];

    /// <summary>
    /// Indicator of the number of movement records contained in an individual settlement request.
    /// </summary>
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    public IsoNumber? NumberOfMovementRecords { get; init; }

    /// <summary>
    /// Identification of the settlement cycle in the settlement service.
    /// </summary>
    /// <remarks>
    /// Usage: The SettlementCycle is used to differentiate this multilateral settlement from other multilateral settlements where more than one occurs within a given time period.
    /// </remarks>
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public IsoMax35Text? SettlementCycle { get; init; }

    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing agent would like the market infrastructure to apply to the processing of the settlement instruction.
    /// </summary>
    /// <remarks>
    /// Usage: Market practice or bilateral agreement should specify how this element should be used. If this element is not populated and there is no market guidance or bilateral agreement, the priority will be considered as 'Normal'.
    /// </remarks>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Provides information on the requested settlement time(s) of the instruction.
    /// </summary>
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }
}
