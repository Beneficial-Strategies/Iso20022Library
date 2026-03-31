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
/// This record is an implementation of the seev.004.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstruction message is sent by a party holding the right to vote to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.
/// Usage
/// The MeetingInstruction message is used to vote, to require attendance to a meeting, to request registration of securities and assign a proxy. One instruction or multiple instructions can be carried within the same message.
/// Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the
/// MeetingInstructionStatus message, a new MeetingInstruction message can be sent.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(
    @"Scope|The MeetingInstruction message is sent by a party holding the right to vote to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.|Usage|The MeetingInstruction message is used to vote, to require attendance to a meeting, to request registration of securities and assign a proxy. One instruction or multiple instructions can be carried within the same message.|Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the|MeetingInstructionStatus message, a new MeetingInstruction message can be sent.|This message definition is intended for use with the Business Application Header (BAH)."
)]
[IsoId("_lKgSgRrdEeyhRdHRjakS2w")]
[DisplayName("Meeting Instruction V")]
public record MeetingInstructionV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.004.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.08";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_lKgShxrdEeyhRdHRjakS2w")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_lKgSiRrdEeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Identification of other messages/documents as well as the messages/documents number.
    /// </summary>
    [IsoId("_lKgSixrdEeyhRdHRjakS2w")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification32? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// The position of the instructing party and the action that it wants to take.
    /// </summary>
    [IsoId("_lKgSjRrdEeyhRdHRjakS2w")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public required Instruction6 Instruction { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_lKgSjxrdEeyhRdHRjakS2w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingInstructionV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionV08.
