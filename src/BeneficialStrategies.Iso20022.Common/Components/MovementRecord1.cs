// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMovementRecord1"/>
[IsoId("_FhFKIJIhEeu5eNv5D0Izbw")]
[DisplayName("Movement Record")]
public partial record MovementRecord1
{
    /// <inheritdoc cref="IMovementRecord1.Identification"/>
    [IsoId("_ehBZgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <inheritdoc cref="IMovementRecord1.SequenceNumber"/>
    [IsoId("_b66S4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <inheritdoc cref="IMovementRecord1.Amount"/>
    [IsoId("_hECv4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection5 Amount { get; init; }

    /// <inheritdoc cref="IMovementRecord1.SettlementAgent"/>
    [IsoId("_GEsfkJfqEeuFlO6opWbACw")]
    [DisplayName("Settlement Agent")]
    [IsoXmlTag("SttlmAgt")]
    public PartyIdentification135? SettlementAgent { get; init; }

    /// <inheritdoc cref="IMovementRecord1.SettlementAgentAccount"/>
    [IsoId("_jbDDgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Settlement Agent Account")]
    [IsoXmlTag("SttlmAgtAcct")]
    public CashAccount40? SettlementAgentAccount { get; init; }

    /// <inheritdoc cref="IMovementRecord1.Participant"/>
    [IsoId("_DF5MIJfqEeuFlO6opWbACw")]
    [DisplayName("Participant")]
    [IsoXmlTag("Ptcpt")]
    public PartyIdentification135? Participant { get; init; }

    /// <inheritdoc cref="IMovementRecord1.ParticipantAccount"/>
    [IsoId("_B7u7UKcuEeuNdKCg1u4vDw")]
    [DisplayName("Participant Account")]
    [IsoXmlTag("PtcptAcct")]
    public CashAccount40? ParticipantAccount { get; init; }

    /// <inheritdoc cref="IMovementRecord1.Reference"/>
    [IsoId("_JW7sYJfqEeuFlO6opWbACw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }
}
