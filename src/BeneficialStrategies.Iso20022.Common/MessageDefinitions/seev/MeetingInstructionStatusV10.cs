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
/// This record is an implementation of the seev.006.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_d7xA8VxxEe6fgZt44_IqFA")]
[DisplayName("Meeting Instruction Status V10")]
public record MeetingInstructionStatusV10 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.006.001.10";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgInstrSts";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.006.001.10";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Confirming Party.
    /// </summary>
    [DisplayName("Confirming Party")]
    [IsoXmlTag("CnfrmgPty")]
    public required PartyIdentification226Choice_ ConfirmingParty { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Instruction Type.
    /// </summary>
    [DisplayName("Instruction Type")]
    [IsoXmlTag("InstrTp")]
    public required InstructionType2Choice_ InstructionType { get; init; }

    /// <summary>
    /// Instruction Type Status.
    /// </summary>
    [DisplayName("Instruction Type Status")]
    [IsoXmlTag("InstrTpSts")]
    public required InstructionTypeStatus6Choice_ InstructionTypeStatus { get; init; }

    /// <summary>
    /// Meeting Reference.
    /// </summary>
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Position.
    /// </summary>
    [DisplayName("Position")]
    [IsoXmlTag("Pos")]
    public EligiblePosition17? Position { get; init; }

    /// <summary>
    /// Rights Holder.
    /// </summary>
    [DisplayName("Rights Holder")]
    [IsoXmlTag("RghtsHldr")]
    public PartyIdentification246Choice_? RightsHolder { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Vote Casting Party.
    /// </summary>
    [DisplayName("Vote Casting Party")]
    [IsoXmlTag("VoteCstgPty")]
    public required PartyIdentification226Choice_ VoteCastingParty { get; init; }
}

// Since MeetingInstructionStatusV10Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingInstructionStatusV10.
