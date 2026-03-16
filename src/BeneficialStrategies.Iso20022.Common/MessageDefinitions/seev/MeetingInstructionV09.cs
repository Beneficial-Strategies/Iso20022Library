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
/// This record is an implementation of the seev.004.001.09 ISO standard message type.
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
[IsoId("_nIzHsTQ7Ee22Z83HpR5E8w")]
[DisplayName("Meeting Instruction V")]
public record MeetingInstructionV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.004.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.004.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part instruction is to continue or that the message is the last page of the multi-part instruction.
    /// </summary>
    [IsoId("_xiGS4TT-Ee2tRf29bleifQ")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// Unique identification of the group of meeting instruction messages when the instruction is split in multiple (paginated) messages.
    /// </summary>
    [IsoId("_7o9OIDT-Ee2tRf29bleifQ")]
    [DisplayName("Meeting Instruction Identification")]
    [IsoXmlTag("MtgInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MeetingInstructionIdentification { get; init; }

    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIzHtzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Security for which the meeting is organised.
    /// </summary>
    [IsoId("_nIzHuTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Identification of the cancellation request message requesting cancellation of individual instruction(s).
    /// </summary>
    [IsoId("_J-5jgDUAEe2tRf29bleifQ")]
    [DisplayName("Instruction Cancellation Request Identification")]
    [IsoXmlTag("InstrCxlReqId")]
    public MeetingInstructionCancellation1? InstructionCancellationRequestIdentification { get; init; }

    /// <summary>
    /// Identification of the message and individual instruction(s) for which the cancellation was requested.
    /// </summary>
    [IsoId("_bAVEMDUAEe2tRf29bleifQ")]
    [DisplayName("Cancelled Instruction Identification")]
    [IsoXmlTag("CancInstrId")]
    public MeetingInstructionIdentification1? CancelledInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of other messages/documents as well as the messages/documents number.
    /// </summary>
    [IsoId("_nIzHuzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification32? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// The position of the instructing party and the action that it wants to take.
    /// </summary>
    [IsoId("_nIzHvTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Instruction")]
    [IsoXmlTag("Instr")]
    public required Instruction7 Instruction { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzHvzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingInstructionV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionV09.
