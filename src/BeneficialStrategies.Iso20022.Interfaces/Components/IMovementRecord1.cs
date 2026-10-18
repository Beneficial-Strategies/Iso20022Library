// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a movement record requested in a single settlement instruction.
/// </summary>
[IsoId("_FhFKIJIhEeu5eNv5D0Izbw")]
public interface IMovementRecord1 : IIsoComponent
{
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the specific movement record (transaction) within a settlement request.
    /// Usage: The movement identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual movement record within a settlement request. It can be included in several messages related to the movement.
    /// </summary>
    [IsoId("_ehBZgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    IsoMax35Text Identification { get; }

    /// <summary>
    /// An index to identify the individual movement record entry.
    /// </summary>
    [IsoId("_b66S4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    IsoNumber? SequenceNumber { get; }

    /// <summary>
    /// Amount of money requested by the instructing agent for settlement at the market infrastructure in a single movement record entry.
    /// </summary>
    [IsoId("_hECv4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    IAmountAndDirection5 Amount { get; }

    /// <summary>
    /// Agent in whose account the funds settle on behalf of the participant.
    /// </summary>
    [IsoId("_GEsfkJfqEeuFlO6opWbACw")]
    [DisplayName("Settlement Agent")]
    [IsoXmlTag("SttlmAgt")]
    IPartyIdentification135? SettlementAgent { get; }

    /// <summary>
    /// Unambiguous identification of the account of the settlement agent.
    /// </summary>
    [IsoId("_jbDDgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Settlement Agent Account")]
    [IsoXmlTag("SttlmAgtAcct")]
    ICashAccount40? SettlementAgentAccount { get; }

    /// <summary>
    /// Identification of a participant on behalf of which the settlement agent instructs the market infrastructure to settle the obligations using accounts held in the settlement service.
    /// </summary>
    [IsoId("_DF5MIJfqEeuFlO6opWbACw")]
    [DisplayName("Participant")]
    [IsoXmlTag("Ptcpt")]
    IPartyIdentification135? Participant { get; }

    /// <summary>
    /// Unambiguous identification of the account of the participant held in the settlement service.
    /// </summary>
    [IsoId("_B7u7UKcuEeuNdKCg1u4vDw")]
    [DisplayName("Participant Account")]
    [IsoXmlTag("PtcptAcct")]
    ICashAccount40? ParticipantAccount { get; }

    /// <summary>
    /// Reference information to complement a movement record.
    /// </summary>
    [IsoId("_JW7sYJfqEeuFlO6opWbACw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    IsoMax35Text? Reference { get; }
}
