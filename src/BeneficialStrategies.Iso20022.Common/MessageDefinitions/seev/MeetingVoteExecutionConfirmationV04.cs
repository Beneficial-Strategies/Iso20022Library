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
/// This record is an implementation of the seev.007.001.04 ISO standard message type.
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
[IsoId("_TuPGudEwEd-BzquC8wXy7w_-1013615131")]
[DisplayName("Meeting Vote Execution Confirmation V")]
public record MeetingVoteExecutionConfirmationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.04";

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
    [IsoId("_TuPGutEwEd-BzquC8wXy7w_389522714")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required MessageIdentification1 Identification { get; init; }

    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_TuPGu9EwEd-BzquC8wXy7w_-1734273210")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required MessageIdentification RelatedReference { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TuPGvNEwEd-BzquC8wXy7w_1925662240")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference4 MeetingReference { get; init; }

    /// <summary>
    /// Party confirming the votes.
    /// </summary>
    [IsoId("_TuY3sNEwEd-BzquC8wXy7w_-694238915")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required PartyIdentification9Choice_ ReportingParty { get; init; }

    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_TuY3sdEwEd-BzquC8wXy7w_-1766243974")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification11 SecurityIdentification { get; init; }

    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_TuY3stEwEd-BzquC8wXy7w_-2084020635")]
    [DisplayName("Vote Instructions")]
    [IsoXmlTag("VoteInstrs")]
    public required DetailedInstructionStatus9 VoteInstructions { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TuY3s9EwEd-BzquC8wXy7w_1171570217")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since MeetingVoteExecutionConfirmationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingVoteExecutionConfirmationV04.
