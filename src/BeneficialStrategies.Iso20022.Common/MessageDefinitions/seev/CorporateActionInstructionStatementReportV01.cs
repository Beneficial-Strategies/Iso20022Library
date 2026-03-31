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
/// This record is an implementation of the seev.042.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionInstructionStatementReport message to an account owner or its designated agent to report balances at the safekeeping account level for one or more corporate action events or at the corporate action event level for one or more safekeeping accounts.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionInstructionStatementReport message to an account owner or its designated agent to report balances at the safekeeping account level for one or more corporate action events or at the corporate action event level for one or more safekeeping accounts.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_TW16YtEwEd-BzquC8wXy7w_1268238631")]
[DisplayName("Corporate Action Instruction Statement Report V")]
public record CorporateActionInstructionStatementReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.042.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnInstrStmtRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.042.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies a CorporateActionInstructionStatementReport message as know by the account servicer. When the report has multiple pages, one message equals one page. Therefore, Identification uniquely identifies the page.
    /// </summary>
    [IsoId("_TW16Y9EwEd-BzquC8wXy7w_-1204031802")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification11 Identification { get; init; }

    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_TW16ZNEwEd-BzquC8wXy7w_1211303543")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination Pagination { get; init; }

    /// <summary>
    /// General characteristics related to a statement which reports information.
    /// </summary>
    [IsoId("_TW16ZdEwEd-BzquC8wXy7w_436859901")]
    [DisplayName("Statement General Details")]
    [IsoXmlTag("StmtGnlDtls")]
    public required Statement12 StatementGeneralDetails { get; init; }

    /// <summary>
    /// Account information and detailed account holdings information report for corporate action events.
    /// </summary>
    [IsoId("_TW16ZtEwEd-BzquC8wXy7w_-1280073177")]
    [DisplayName("Account And Statement Details")]
    [IsoXmlTag("AcctAndStmtDtls")]
    public required AccountIdentification6 AccountAndStatementDetails { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_TW16Z9EwEd-BzquC8wXy7w_-570637514")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_TW16aNEwEd-BzquC8wXy7w_-529079840")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TW_EUNEwEd-BzquC8wXy7w_-884634108")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since CorporateActionInstructionStatementReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionInstructionStatementReportV01.
