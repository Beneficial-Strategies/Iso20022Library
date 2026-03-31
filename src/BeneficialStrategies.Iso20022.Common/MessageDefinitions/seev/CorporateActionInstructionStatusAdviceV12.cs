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
/// This record is an implementation of the seev.034.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionInstructionStatusAdvice message is sent by an account servicer to an account owner or its designated agent, to report the status of a received corporate action election instruction.|
/// This message is used to advise the status, or a change in status, of a corporate action-related transaction previously instructed by, or executed on behalf of, the account owner. This will include the acknowledgement/rejection of a corporate action instruction.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|The CorporateActionInstructionStatusAdvice message is sent by an account servicer to an account owner or its designated agent, to report the status of a received corporate action election instruction.||This message is used to advise the status, or a change in status, of a corporate action-related transaction previously instructed by, or executed on behalf of, the account owner. This will include the acknowledgement/rejection of a corporate action instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH)."
)]
[IsoId("_B3MKbe2zEeqc-LCjwLsUVg")]
[DisplayName("Corporate Action Instruction Status Advice V")]
public record CorporateActionInstructionStatusAdviceV12 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.034.001.12";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.034.001.12";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_B3MKd-2zEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_B3MKee2zEeqc-LCjwLsUVg")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification33? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_B3MKe-2zEeqc-LCjwLsUVg")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation154 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Information about the processing status of the instruction.
    /// </summary>
    [IsoId("_B3MKfe2zEeqc-LCjwLsUVg")]
    [DisplayName("Instruction Processing Status")]
    [IsoXmlTag("InstrPrcgSts")]
    public required InstructionProcessingStatus40Choice_ InstructionProcessingStatus { get; init; }

    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_B3MKf-2zEeqc-LCjwLsUVg")]
    [DisplayName("Corporate Action Instruction")]
    [IsoXmlTag("CorpActnInstr")]
    public CorporateActionOption184? CorporateActionInstruction { get; init; }

    /// <summary>
    /// Provides detailed information on protect and cover protect instructions.
    /// </summary>
    [IsoId("_B3MKge2zEeqc-LCjwLsUVg")]
    [DisplayName("Protect Instruction")]
    [IsoXmlTag("PrtctInstr")]
    public ProtectInstruction2? ProtectInstruction { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_B3MKg-2zEeqc-LCjwLsUVg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative10? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_B3MKhe2zEeqc-LCjwLsUVg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionInstructionStatusAdviceV12Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstructionStatusAdviceV12.
