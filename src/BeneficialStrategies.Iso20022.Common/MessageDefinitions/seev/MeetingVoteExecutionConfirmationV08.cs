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
/// This record is an implementation of the seev.007.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.
/// Usage
/// This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.
/// This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(
    @"Scope|The MeetingVoteExecutionConfirmation message is sent by an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to confirm, to the Sender of the MeetingInstruction message, that their vote has been recorded and counted by the Issuer.|Usage|This message is sent after the shareholders meeting has taken place. The Sender of this message confirms the execution of the vote at the meeting.|This messages is sent if the Sender of the MeetingInstruction message has requested such a confirmation or if market practice or regulation stipulates the need for a full audit trail.|This message definition is intended for use with the Business Application Header (BAH)."
)]
[IsoId("_lKgSuxrdEeyhRdHRjakS2w")]
[DisplayName("Meeting Vote Execution Confirmation V")]
public record MeetingVoteExecutionConfirmationV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.007.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgVoteExctnConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.007.001.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of the original meeting instruction message for which the vote execution  confirmation is provided.
    /// </summary>
    [IsoId("_lKgSwxrdEeyhRdHRjakS2w")]
    [DisplayName("Meeting Instruction Identification")]
    [IsoXmlTag("MtgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MeetingInstructionIdentification { get; init; }

    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_lKgSxRrdEeyhRdHRjakS2w")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_lKgSxxrdEeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies how a party has voted for each agenda item.
    /// </summary>
    [IsoId("_lKgSyRrdEeyhRdHRjakS2w")]
    [DisplayName("Vote Instructions")]
    [IsoXmlTag("VoteInstrs")]
    public DetailedInstructionStatus17? VoteInstructions { get; init; }

    /// <summary>
    /// Address to use over the www (HTTP) service where the confirmations of the vote instructions can be found.
    /// </summary>
    [IsoId("_lKgSyxrdEeyhRdHRjakS2w")]
    [DisplayName("Vote Instructions Confirmation URL Address")]
    [IsoXmlTag("VoteInstrsConfURLAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048, MinimumLength = 1)]
    public IsoMax2048Text? VoteInstructionsConfirmationURLAddress { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_lKgSzRrdEeyhRdHRjakS2w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingVoteExecutionConfirmationV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingVoteExecutionConfirmationV08.
