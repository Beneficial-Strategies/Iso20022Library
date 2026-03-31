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
/// This record is an implementation of the seev.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstructionCancellationRequest message is sent by the same party that sent the MeetingInstruction message. It is sent to request the cancellation of all instructions included in the original the MeetingInstruction message.
/// Usage
/// This message must be answered by a MeetingInstructionStatus message. Some instructions in the previously sent MeetingInstruction message may have already been executed and cannot be cancelled. This information should appear clearly in the status message.
/// </summary>
[Description(
    @"Scope|The MeetingInstructionCancellationRequest message is sent by the same party that sent the MeetingInstruction message. It is sent to request the cancellation of all instructions included in the original the MeetingInstruction message.|Usage|This message must be answered by a MeetingInstructionStatus message. Some instructions in the previously sent MeetingInstruction message may have already been executed and cannot be cancelled. This information should appear clearly in the status message."
)]
[IsoId("_TnFV2tEwEd-BzquC8wXy7w_-50610544")]
[DisplayName("Meeting Instruction Cancellation Request V")]
public record MeetingInstructionCancellationRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.005.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.005.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Uniquely identifies the cancellation request.
    /// </summary>
    [IsoId("_TnFV29EwEd-BzquC8wXy7w_-50610266")]
    [DisplayName("Instruction Cancellation Identification")]
    [IsoXmlTag("InstrCxlId")]
    public required MessageIdentification1 InstructionCancellationIdentification { get; init; }

    /// <summary>
    /// Identifies the instruction to be cancelled.
    /// </summary>
    [IsoId("_TnFV3NEwEd-BzquC8wXy7w_-50610509")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required MessageIdentification PreviousReference { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TnPG0NEwEd-BzquC8wXy7w_-50610526")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public MeetingReference3? MeetingReference { get; init; }

    /// <summary>
    /// Party requesting the cancellation.
    /// </summary>
    [IsoId("_TnPG0dEwEd-BzquC8wXy7w_-50610497")]
    [DisplayName("Requesting Party")]
    [IsoXmlTag("RqstngPty")]
    public PartyIdentification9Choice_? RequestingParty { get; init; }

    /// <summary>
    /// Identifies the security for which the meeting is organised.
    /// </summary>
    [IsoId("_TnPG0tEwEd-BzquC8wXy7w_-1638529229")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public SecurityIdentification3? SecurityIdentification { get; init; }

    /// <summary>
    /// Identifies the account and instructed positions for which the instruction cancellation request applies.
    /// </summary>
    [IsoId("_TnPG09EwEd-BzquC8wXy7w_-2011631186")]
    [DisplayName("Instructed Position")]
    [IsoXmlTag("InstdPos")]
    public SafekeepingAccount3? InstructedPosition { get; init; }
}

// Since MeetingInstructionCancellationRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionCancellationRequestV02.
