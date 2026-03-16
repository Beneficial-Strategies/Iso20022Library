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
/// This record is an implementation of the seev.033.002.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_kV1Qg5t3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Instruction002V13")]
public record CorporateActionInstruction002V13 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.033.002.13";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.033.002.13";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Account Details.
    /// </summary>
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountAndBalance62 AccountDetails { get; init; }

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative34? AdditionalInformation { get; init; }

    /// <summary>
    /// Beneficial Owner Details.
    /// </summary>
    [DisplayName("Beneficial Owner Details")]
    [IsoXmlTag("BnfclOwnrDtls")]
    public ValueList<PartyIdentification317> BeneficialOwnerDetails { get; init; } = [];

    /// <summary>
    /// Cancelled Instruction Identification.
    /// </summary>
    [DisplayName("Cancelled Instruction Identification")]
    [IsoXmlTag("CancInstrId")]
    public DocumentIdentification37? CancelledInstructionIdentification { get; init; }

    /// <summary>
    /// Change Instruction Indicator.
    /// </summary>
    [DisplayName("Change Instruction Indicator")]
    [IsoXmlTag("ChngInstrInd")]
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; }

    /// <summary>
    /// Corporate Action General Information.
    /// </summary>
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation189 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Corporate Action Instruction.
    /// </summary>
    [DisplayName("Corporate Action Instruction")]
    [IsoXmlTag("CorpActnInstr")]
    public required CorporateActionOption243 CorporateActionInstruction { get; init; }

    /// <summary>
    /// Events Linkage.
    /// </summary>
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public ValueList<CorporateActionEventReference4> EventsLinkage { get; init; } = [];

    /// <summary>
    /// Instruction Cancellation Request Identification.
    /// </summary>
    [DisplayName("Instruction Cancellation Request Identification")]
    [IsoXmlTag("InstrCxlReqId")]
    public DocumentIdentification37? InstructionCancellationRequestIdentification { get; init; }

    /// <summary>
    /// Other Document Identification.
    /// </summary>
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public ValueList<DocumentIdentification38> OtherDocumentIdentification { get; init; } = [];

    /// <summary>
    /// Protect Instruction.
    /// </summary>
    [DisplayName("Protect Instruction")]
    [IsoXmlTag("PrtctInstr")]
    public ProtectInstruction5? ProtectInstruction { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since CorporateActionInstruction002V13Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstruction002V13.
