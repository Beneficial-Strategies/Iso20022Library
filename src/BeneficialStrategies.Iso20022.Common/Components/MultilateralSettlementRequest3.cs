// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Multilateral Settlement Request3.
/// </summary>
[IsoId("_z-2GQTEyEe6g-ffJsqGiSA")]
[DisplayName("Multilateral Settlement Request3")]
public record MultilateralSettlementRequest3
{
    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Instruction Priority.
    /// </summary>
    [DisplayName("Instruction Priority")]
    [IsoXmlTag("InstrPrty")]
    public Priority3Code? InstructionPriority { get; init; }

    /// <summary>
    /// Movement Record.
    /// </summary>
    [DisplayName("Movement Record")]
    [IsoXmlTag("MvmntRcrd")]
    public ValueList<MovementRecord2> MovementRecord { get; init; } = [];

    /// <summary>
    /// Number Of Movement Records.
    /// </summary>
    [DisplayName("Number Of Movement Records")]
    [IsoXmlTag("NbOfMvmntRcrds")]
    public IsoNumber? NumberOfMovementRecords { get; init; }

    /// <summary>
    /// Settlement Cycle.
    /// </summary>
    [DisplayName("Settlement Cycle")]
    [IsoXmlTag("SttlmCycl")]
    public IsoMax35Text? SettlementCycle { get; init; }

    /// <summary>
    /// Settlement Priority.
    /// </summary>
    [DisplayName("Settlement Priority")]
    [IsoXmlTag("SttlmPrty")]
    public Priority3Code? SettlementPriority { get; init; }

    /// <summary>
    /// Settlement Time Request.
    /// </summary>
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; }
}
