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
/// This record is an implementation of the seev.041.002.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionInstructionCancellationRequestStatusAdvice message to an account owner or its designated agent to report status of a previously received CorporateActionInstructionCancellationRequest message sent by the account owner. This will include the acknowledgement/rejection of a request to cancel an outstanding instruction.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionInstructionCancellationRequestStatusAdvice message to an account owner or its designated agent to report status of a previously received CorporateActionInstructionCancellationRequest message sent by the account owner. This will include the acknowledgement/rejection of a request to cancel an outstanding instruction. |Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH)."
)]
[IsoId("_ce-SI5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Instruction Cancellation Request Status Advice 002 V")]
public record CorporateActionInstructionCancellationRequestStatusAdvice002V06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.041.002.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrCxlReqStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.041.002.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification of a related instruction cancellation request document.
    /// </summary>
    [IsoId("_ce-SJ5KQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Cancellation Request Identification")]
    [IsoXmlTag("InstrCxlReqId")]
    public DocumentIdentification17? InstructionCancellationRequestIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_ce-SKZKQEeWHWpTQn1FFVg")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification34? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_ce-SK5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation94 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Provides information about the processing status of the instruction cancellation request.
    /// </summary>
    [IsoId("_ce-SLZKQEeWHWpTQn1FFVg")]
    [DisplayName("Instruction Cancellation Request Status")]
    [IsoXmlTag("InstrCxlReqSts")]
    public required InstructionCancellationRequestStatus10Choice_ InstructionCancellationRequestStatus { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_ce-SL5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Instruction")]
    [IsoXmlTag("CorpActnInstr")]
    public CorporateActionOption121? CorporateActionInstruction { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_ce-SMZKQEeWHWpTQn1FFVg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative19? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ce-SM5KQEeWHWpTQn1FFVg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionInstructionCancellationRequestStatusAdvice002V06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstructionCancellationRequestStatusAdvice002V06.
