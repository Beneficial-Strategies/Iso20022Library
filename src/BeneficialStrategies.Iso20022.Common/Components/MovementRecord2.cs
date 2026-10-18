// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMovementRecord2"/>
[Description(@"Details of a movement record requested in a single settlement instruction.")]
[IsoId("_0BP6ATEyEe6g-ffJsqGiSA")]
[DisplayName("Movement Record2")]
public partial record MovementRecord2
{
    /// <inheritdoc cref="IMovementRecord2.Amount"/>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection5 Amount { get; init; }

    /// <inheritdoc cref="IMovementRecord2.Identification"/>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <inheritdoc cref="IMovementRecord2.Participant"/>
    [DisplayName("Participant")]
    [IsoXmlTag("Ptcpt")]
    public PartyIdentification272? Participant { get; init; }

    /// <inheritdoc cref="IMovementRecord2.ParticipantAccount"/>
    [DisplayName("Participant Account")]
    [IsoXmlTag("PtcptAcct")]
    public CashAccount40? ParticipantAccount { get; init; }

    /// <inheritdoc cref="IMovementRecord2.Reference"/>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public IsoMax35Text? Reference { get; init; }

    /// <inheritdoc cref="IMovementRecord2.SequenceNumber"/>
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="IMovementRecord2.SettlementAgent"/>
    [DisplayName("Settlement Agent")]
    [IsoXmlTag("SttlmAgt")]
    public PartyIdentification272? SettlementAgent { get; init; }

    /// <inheritdoc cref="IMovementRecord2.SettlementAgentAccount"/>
    [DisplayName("Settlement Agent Account")]
    [IsoXmlTag("SttlmAgtAcct")]
    public CashAccount40? SettlementAgentAccount { get; init; }
}
