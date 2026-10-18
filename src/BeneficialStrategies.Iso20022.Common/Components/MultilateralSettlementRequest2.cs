// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMultilateralSettlementRequest2"/>
[IsoId("_I5-6EQcZEeyTDbUIoCmuCw")]
[DisplayName("Multilateral Settlement Request")]
public partial record MultilateralSettlementRequest2
{
    /// <inheritdoc cref="IMultilateralSettlementRequest2.InstructionIdentification"/>
    [IsoId("_I-zvsQcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest2.InstructionPriority"/>
    [IsoId("_I-zvswcZEeyTDbUIoCmuCw")]
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority3Code? InstructionPriority { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest2.SettlementTimeRequest"/>
    [IsoId("_I-zvtwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest2.SettlementPriority"/>
    [IsoId("_I-zvuQcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest2.SettlementCycle"/>
    [IsoId("_I-zvuwcZEeyTDbUIoCmuCw")]
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SettlementCycle { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest2.NumberOfMovementRecords"/>
    [IsoId("_I-zvvQcZEeyTDbUIoCmuCw")]
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfMovementRecords { get; init; }

    /// <inheritdoc cref="IMultilateralSettlementRequest2.MovementRecord"/>
    [IsoId("_I-zvvwcZEeyTDbUIoCmuCw")]
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    public ValueList<MovementRecord1> MovementRecord { get; init; } = [];
    // ID for the above is _I-zvvwcZEeyTDbUIoCmuCw
}
