// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMultilateralSettlementRequest3"/>
[Description(@"Provides details specific to the individual settlement instruction(s) included in the message.")]
[IsoId("_z-2GQTEyEe6g-ffJsqGiSA")]
[DisplayName("Multilateral Settlement Request3")]
public partial record MultilateralSettlementRequest3
{
    /// <inheritdoc cref="IMultilateralSettlementRequest3.InstructionIdentification"/>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest3.InstructionPriority"/>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority3Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest3.MovementRecord"/>
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    public ValueList<MovementRecord2> MovementRecord { get; init; } = [];

    /// <inheritdoc cref="IMultilateralSettlementRequest3.NumberOfMovementRecords"/>
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    public IsoNumber? NumberOfMovementRecords { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest3.SettlementCycle"/>
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public IsoMax35Text? SettlementCycle { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest3.SettlementPriority"/>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest3.SettlementTimeRequest"/>
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }
}
