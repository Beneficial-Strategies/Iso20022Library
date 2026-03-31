// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// </summary>
[Description(
    @"Scope|An issuer, its agent or an intermediary sends the MeetingVoteExecutionConfirmation message to confirm to the Sender of the MeetingInstruction message, the execution of their voting instruction.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting and confirms that the vote has been processed as instructed via the MeetingInstruction message.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail."
)]
[IsoId("_Ttyay9EwEd-BzquC8wXy7w_1192448161")]
[DisplayName("Meeting Vote Execution Confirmation V")]
public record MeetingVoteExecutionConfirmationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the vote execution confirmation message.
    /// </summary>
    [IsoId("_TtyazNEwEd-BzquC8wXy7w_1192448199")]
    [DisplayName("Vote Execution Confirmation Identification")]
    [IsoXmlTag("VoteExctnConfId")]
    public required MessageIdentification1 VoteExecutionConfirmationIdentification { get; init; }

    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_Tt8LwNEwEd-BzquC8wXy7w_1192448163")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required MessageIdentification RelatedReference { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tt8LwdEwEd-BzquC8wXy7w_1192448179")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference3 MeetingReference { get; init; }

    /// <summary>
    /// Party confirming the votes.
    /// </summary>
    [IsoId("_Tt8LwtEwEd-BzquC8wXy7w_1192448214")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required PartyIdentification9Choice_ ReportingParty { get; init; }

    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_Tt8Lw9EwEd-BzquC8wXy7w_-1409853595")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification3 SecurityIdentification { get; init; }

    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_Tt8LxNEwEd-BzquC8wXy7w_603156788")]
    [DisplayName("Vote Instruction")]
    [IsoXmlTag("VoteInstr")]
    public required DetailedInstructionStatus2 VoteInstruction { get; init; }
}

// Since MeetingVoteExecutionConfirmationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingVoteExecutionConfirmationV02.
