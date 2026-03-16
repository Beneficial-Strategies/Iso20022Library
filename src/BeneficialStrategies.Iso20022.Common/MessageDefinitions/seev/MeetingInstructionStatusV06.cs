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
/// This record is an implementation of the seev.006.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingInstructionStatus message is sent by an intermediary to the sender of an instruction to confirm the status of such an instruction. The message gives the status of a complete message or of one or more specific instructions within the message.
/// The message may also be sent by the Issuer or the intermediary to confirm that a vote has been cast.
/// Usage
/// The MeetingInstructionStatus message is used for four purposes.
/// First, it is used to provide a global processing or rejection status of a MeetingInstruction message.
/// Second, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.
/// Third, it is used to provide a detailed processing or rejection status of one or more instructions within the MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the SingleInstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.
/// Fourth, it is used to confirm that the related vote instruction has been confirmed as cast by the issuer or its agent.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(
    @"Scope|The MeetingInstructionStatus message is sent by an intermediary to the sender of an instruction to confirm the status of such an instruction. The message gives the status of a complete message or of one or more specific instructions within the message.|The message may also be sent by the Issuer or the intermediary to confirm that a vote has been cast.|Usage|The MeetingInstructionStatus message is used for four purposes.|First, it is used to provide a global processing or rejection status of a MeetingInstruction message.|Second, it provides the status on the processing of a MeetingInstructionCancellationRequest message, for example, whether the request message is rejected or accepted.|Third, it is used to provide a detailed processing or rejection status of one or more instructions within the MeetingInstruction message, for example, for each instruction in the MeetingInstruction message the processing or rejection status is individually reported by using the SingleInstructionIdentification element. This identification allows the receiver of the status message to link the status confirmation to its original instruction.|Fourth, it is used to confirm that the related vote instruction has been confirmed as cast by the issuer or its agent.|This message definition is intended for use with the Business Application Header."
)]
[IsoId("_yXBbd6yREemMosWmlQ33EA")]
[DisplayName("Meeting Instruction Status V")]
public record MeetingInstructionStatusV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.06";

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
    [IsoId("_yXBbf6yREemMosWmlQ33EA")]
    [DisplayName("Instruction Type")]
    [IsoXmlTag("InstrTp")]
    public required InstructionType2Choice_ InstructionType { get; init; }

    /// <summary>
    /// Set of elements that allow to identify unambiguously a meeting.
    /// </summary>
    [IsoId("_yXBbgayREemMosWmlQ33EA")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference8 MeetingReference { get; init; }

    /// <summary>
    /// Securities for which the meeting is organised.
    /// </summary>
    [IsoId("_yXBbg6yREemMosWmlQ33EA")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Type of instruction status.
    /// </summary>
    [IsoId("_yXBbhayREemMosWmlQ33EA")]
    [DisplayName("Instruction Type Status")]
    [IsoXmlTag("InstrTpSts")]
    public required InstructionTypeStatus3Choice_ InstructionTypeStatus { get; init; }

    /// <summary>
    /// Party that confirms the receipt of the vote cast.
    /// </summary>
    [IsoId("_meGP0K-iEemJ1NnLPsTFaw")]
    [DisplayName("Confirming Party")]
    [IsoXmlTag("CnfrmgPty")]
    public required PartyIdentification226Choice_ ConfirmingParty { get; init; }

    /// <summary>
    /// Party that cast the voting ballot.
    /// </summary>
    [IsoId("_UojDMK-lEemJ1NnLPsTFaw")]
    [DisplayName("Vote Casting Party")]
    [IsoXmlTag("VoteCstgPty")]
    public required PartyIdentification226Choice_ VoteCastingParty { get; init; }

    /// <summary>
    /// Owner of the voting rights.
    /// </summary>
    [IsoId("_fWGLAK-lEemJ1NnLPsTFaw")]
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public PartyIdentification227Choice_? RightsHolder { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbh6yREemMosWmlQ33EA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingInstructionStatusV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV06.
