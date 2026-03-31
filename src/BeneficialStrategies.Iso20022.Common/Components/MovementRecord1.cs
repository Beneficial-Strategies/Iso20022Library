// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a movement record requested in a single settlement instruction.
/// </summary>
[IsoId("_FhFKIJIhEeu5eNv5D0Izbw")]
[DisplayName("Movement Record")]
public record MovementRecord1
{
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the specific movement record (transaction) within a settlement request.
    /// Usage: The movement identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual movement record within a settlement request. It can be included in several messages related to the movement.
    /// </summary>
    [IsoId("_ehBZgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// An index to identify the individual movement record entry.
    /// </summary>
    [IsoId("_b66S4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SequenceNumber { get; init; }

    /// <summary>
    /// Amount of money requested by the instructing agent for settlement at the market infrastructure in a single movement record entry.
    /// </summary>
    [IsoId("_hECv4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountAndDirection5 Amount { get; init; }

    /// <summary>
    /// Agent in whose account the funds settle on behalf of the participant.
    /// </summary>
    [IsoId("_GEsfkJfqEeuFlO6opWbACw")]
    [DisplayName("Settlement Agent")]
    [IsoXmlTag("SttlmAgt")]
    public PartyIdentification135? SettlementAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the settlement agent.
    /// </summary>
    [IsoId("_jbDDgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Settlement Agent Account")]
    [IsoXmlTag("SttlmAgtAcct")]
    public CashAccount40? SettlementAgentAccount { get; init; }

    /// <summary>
    /// Identification of a participant on behalf of which the settlement agent instructs the market infrastructure to settle the obligations using accounts held in the settlement service.
    /// </summary>
    [IsoId("_DF5MIJfqEeuFlO6opWbACw")]
    [DisplayName("Participant")]
    [IsoXmlTag("Ptcpt")]
    public PartyIdentification135? Participant { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the participant held in the settlement service.
    /// </summary>
    [IsoId("_B7u7UKcuEeuNdKCg1u4vDw")]
    [DisplayName("Participant Account")]
    [IsoXmlTag("PtcptAcct")]
    public CashAccount40? ParticipantAccount { get; init; }

    /// <summary>
    /// Reference information to complement a movement record.
    /// </summary>
    [IsoId("_JW7sYJfqEeuFlO6opWbACw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }
}
