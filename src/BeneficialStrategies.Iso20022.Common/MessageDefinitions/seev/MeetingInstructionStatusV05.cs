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
/// This record is an implementation of the seev.006.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.
/// The message gives the status of a complete message or of one or more specific instructions within the message.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.
/// Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).
/// Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(
    @"Scope|The Receiver of the MeetingInstruction or MeetingInstructionCancellationRequest sends the MeetingInstructionStatus message to the Sender of these messages.|The message gives the status of a complete message or of one or more specific instructions within the message.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.|Second, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Third, it is used to provide a detailed processing or rejection status of a MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the InstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|The blocking of securities should be confirmed via an MT 508 (Intra-Position Advice).|Fourth, it is used as a reminder to request voting instructions. This is done by indicating NONREF in the Identification element of the InstructionIdentification component and by using the status code NotReceived in the ProcessingStatus.|This message definition is intended for use with the Business Application Header."
)]
[IsoId("_xDAOO1tcEeSwKe7KuKvXhg")]
[DisplayName("Meeting Instruction Status V")]
public record MeetingInstructionStatusV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Type of instruction.
    /// </summary>
    [IsoId("_xDAORVtcEeSwKe7KuKvXhg")]
    [DisplayName("Instruction Type")]
    [IsoXmlTag("InstrTp")]
    public required InstructionType1Choice_ InstructionType { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_xDAOR1tcEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference7 MeetingReference { get; init; }

    /// <summary>
    /// Identifies the securities for which the meeting is organised.
    /// </summary>
    [IsoId("_xDAOS1tcEeSwKe7KuKvXhg")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Type of instruction status.
    /// </summary>
    [IsoId("_xDAOTVtcEeSwKe7KuKvXhg")]
    [DisplayName("Instruction Type Status")]
    [IsoXmlTag("InstrTpSts")]
    public required InstructionTypeStatus2Choice_ InstructionTypeStatus { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_sMzdoVtoEeSwKe7KuKvXhg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingInstructionStatusV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV05.
