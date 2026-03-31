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
/// This record is an implementation of the seev.033.002.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends the CorporateActionInstruction message to an account servicer to instruct election on a corporate action event.|
/// This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|An account owner sends the CorporateActionInstruction message to an account servicer to instruct election on a corporate action event.||This message is used to provide the custodian with instructions on how the account owner wishes to proceed with a corporate action event. Instructions include investment decisions regarding the exercise of rights issues, the election of stock or cash when the option is available, and decisions on the conversion or tendering of securities.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH)."
)]
[IsoId("_WGVb0ZwsEeazcsnODTksnQ")]
[DisplayName("Corporate Action Instruction 002 V")]
public record CorporateActionInstruction002V07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.033.002.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.033.002.07";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// When used in a corporate action instruction, indicates that the current instruction is replacing a previous one that was cancelled earlier. When used in a corporate action instruction cancellation request, indicates that cancelled instruction will be replaced by a new corporate action instruction to be sent later.
    /// </summary>
    [IsoId("_WGVb3ZwsEeazcsnODTksnQ")]
    [DisplayName("Change Instruction Indicator")]
    [IsoXmlTag("ChngInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; }

    /// <summary>
    /// Identification of a previously sent cancelled instruction document.
    /// </summary>
    [IsoId("_WGVb35wsEeazcsnODTksnQ")]
    [DisplayName("Cancelled Instruction Identification")]
    [IsoXmlTag("CancInstrId")]
    public DocumentIdentification37? CancelledInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of a previously sent instruction cancellation request document.
    /// </summary>
    [IsoId("_WGVb4ZwsEeazcsnODTksnQ")]
    [DisplayName("Instruction Cancellation Request Identification")]
    [IsoXmlTag("InstrCxlReqId")]
    public DocumentIdentification37? InstructionCancellationRequestIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_WGVb45wsEeazcsnODTksnQ")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_WGVb5ZwsEeazcsnODTksnQ")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_WGVb55wsEeazcsnODTksnQ")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation115 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_WGVb6ZwsEeazcsnODTksnQ")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountAndBalance37 AccountDetails { get; init; }

    /// <summary>
    /// Provides information about the beneficial owner of the securities.
    /// </summary>
    [IsoId("_WGVb65wsEeazcsnODTksnQ")]
    [DisplayName("Beneficial Owner Details")]
    [IsoXmlTag("BnfclOwnrDtls")]
    public PartyIdentification101? BeneficialOwnerDetails { get; init; }

    /// <summary>
    /// Information about the corporate action instruction.
    /// </summary>
    [IsoId("_WGVb7ZwsEeazcsnODTksnQ")]
    [DisplayName("Corporate Action Instruction")]
    [IsoXmlTag("CorpActnInstr")]
    public required CorporateActionOption134 CorporateActionInstruction { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_WGVb75wsEeazcsnODTksnQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative34? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_WGVb8ZwsEeazcsnODTksnQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionInstruction002V07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstruction002V07.
