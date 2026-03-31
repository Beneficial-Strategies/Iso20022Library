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
/// This record is an implementation of the seev.004.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A party holding the right to vote sends the MeetingInstruction message to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.
/// Usage
/// The MeetingInstruction message is used to register for a shareholders meeting, request blocking or registration of securities. It is used to assign a proxy, to specify the names of meeting attendees and to relay vote instructions per resolution electronically.
/// The MeetingInstruction message may only be sent for one security, though several safekeeping places may be specified.
/// Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the MeetingInstructionStatus message, a new MeetingInstruction message can be sent.
/// </summary>
[Description(
    @"Scope|A party holding the right to vote sends the MeetingInstruction message to an intermediary, the issuer or its agent to request the receiving party to act upon one or several instructions.|Usage|The MeetingInstruction message is used to register for a shareholders meeting, request blocking or registration of securities. It is used to assign a proxy, to specify the names of meeting attendees and to relay vote instructions per resolution electronically.|The MeetingInstruction message may only be sent for one security, though several safekeeping places may be specified.|Once the message is sent, it cannot be modified. It must be cancelled by a MeetingInstructionCancellationRequest. Only after receipt of a confirmed cancelled status via the MeetingInstructionStatus message, a new MeetingInstruction message can be sent."
)]
[IsoId("_Tq9JOdEwEd-BzquC8wXy7w_-1580879636")]
[DisplayName("Meeting Instruction V")]
public record MeetingInstructionV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.004.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the meeting instruction message.
    /// </summary>
    [IsoId("_Tq9JOtEwEd-BzquC8wXy7w_1416416792")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required MessageIdentification1 Identification { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_Tq9JO9EwEd-BzquC8wXy7w_668851111")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference4 MeetingReference { get; init; }

    /// <summary>
    /// Party notifying the instructions.
    /// </summary>
    [IsoId("_Tq9JPNEwEd-BzquC8wXy7w_1200693664")]
    [DisplayName("Instructing Party")]
    [IsoXmlTag("InstgPty")]
    public required PartyIdentification9Choice_ InstructingParty { get; init; }

    /// <summary>
    /// Identifies the security for which the meeting is organised.
    /// </summary>
    [IsoId("_TrG6MNEwEd-BzquC8wXy7w_2100528158")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification11 SecurityIdentification { get; init; }

    /// <summary>
    /// Identifies the position of the instructing party and the action that they want to take.
    /// </summary>
    [IsoId("_TrG6MdEwEd-BzquC8wXy7w_-1116418800")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public required Instruction2 Instruction { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TrG6MtEwEd-BzquC8wXy7w_1093292958")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since MeetingInstructionV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionV04.
