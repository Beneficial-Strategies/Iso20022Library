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

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.006.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AccountManagementStatusReport message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner or its designated agent, for example, an investor to report on the receipt or the processing status of a previously received account management message.
/// Usage
/// The AccountManagementStatusReport message is used to provide the status of a previously received AccountOpeningInstruction, an AccountModificationInstruction or a GetAccountDetails message. It may also be used to report the status of the account.
/// The AccountManagementStatusReport message is also used to reject an AccountOpeningInstruction, AccountModificationInstruction or GetAccountDetails message when the message is not compliant with the agreed SLA or when the account cannot be uniquely identified.
/// </summary>
[Description(
    @"Scope|The AccountManagementStatusReport message is sent by an account servicer, for example, a registrar, transfer agent, custodian bank or securities depository to the account owner or its designated agent, for example, an investor to report on the receipt or the processing status of a previously received account management message.|Usage|The AccountManagementStatusReport message is used to provide the status of a previously received AccountOpeningInstruction, an AccountModificationInstruction or a GetAccountDetails message. It may also be used to report the status of the account. |The AccountManagementStatusReport message is also used to reject an AccountOpeningInstruction, AccountModificationInstruction or GetAccountDetails message when the message is not compliant with the agreed SLA or when the account cannot be uniquely identified."
)]
[IsoId("_9r1N0UNDEeaknIuOb43xYQ")]
[DisplayName("Account Management Status Report V")]
public record AccountManagementStatusReportV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.006.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctMgmtStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.006.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_9r1N00NDEeaknIuOb43xYQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_9r1N1UNDEeaknIuOb43xYQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference6> RelatedReference { get; init; } = [];

    /// <summary>
    /// Status report details of the account management instruction that was previously received.
    /// </summary>
    [IsoId("_9r1N10NDEeaknIuOb43xYQ")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required AccountManagementStatusAndReason5 StatusReport { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_9r1N2UNDEeaknIuOb43xYQ")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_9r1N20NDEeaknIuOb43xYQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since AccountManagementStatusReportV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountManagementStatusReportV06.
