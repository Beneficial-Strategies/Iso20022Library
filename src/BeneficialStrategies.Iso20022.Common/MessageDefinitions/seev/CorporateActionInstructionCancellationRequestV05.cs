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
/// This record is an implementation of the seev.040.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An account owner sends the CorporateActionInstructionCancellationRequest message to an account servicer to request cancellation of a previously sent corporate action election instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE
/// This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account owner sends the CorporateActionInstructionCancellationRequest message to an account servicer to request cancellation of a previously sent corporate action election instruction.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_2B2dCRbDEeOb5dMswipsLQ")]
[DisplayName("Corporate Action Instruction Cancellation Request V")]
public record CorporateActionInstructionCancellationRequestV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.040.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.040.001.05";

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
    [IsoId("_2B2dExbDEeOb5dMswipsLQ")]
    [DisplayName("Change Instruction Indicator")]
    [IsoXmlTag("ChngInstrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChangeInstructionIndicator { get; init; }

    /// <summary>
    /// Identification of a previously sent instruction document.
    /// </summary>
    [IsoId("_2B2dFRbDEeOb5dMswipsLQ")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required DocumentIdentification15 InstructionIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_2B2dFxbDEeOb5dMswipsLQ")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation49 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_2B2dGRbDEeOb5dMswipsLQ")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification15 AccountDetails { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_2B2dGxbDEeOb5dMswipsLQ")]
    [DisplayName("Corporate Action Instruction")]
    [IsoXmlTag("CorpActnInstr")]
    public required CorporateActionOption42 CorporateActionInstruction { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2B2dHRbDEeOb5dMswipsLQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionInstructionCancellationRequestV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstructionCancellationRequestV05.
