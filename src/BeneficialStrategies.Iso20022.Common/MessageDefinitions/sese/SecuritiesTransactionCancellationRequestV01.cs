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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesTransactionCancellationRequest to an account servicer to request the cancellation of a securities transaction.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manage a fund account opened at a custodian, or - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository ot another settlement market infrastructure.
/// Usage
/// The transaction may be:
/// - a securities settlement transaction
/// - an intra-position movement
/// - a securities financing transaction
/// The instruction cannot be:
/// - a securities settlement conditions modification (another transaction processing command should be sent to reverse a processing change previously requested).
/// - a securities financing modification
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account owner sends a SecuritiesTransactionCancellationRequest to an account servicer to request the cancellation of a securities transaction.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or - a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository ot another settlement market infrastructure.|Usage|The transaction may be:|- a securities settlement transaction|- an intra-position movement|- a securities financing transaction|The instruction cannot be:|- a securities settlement conditions modification (another transaction processing command should be sent to reverse a processing change previously requested).|- a securities financing modification|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_EdCB-NE6Ed-BzquC8wXy7w_-363861038")]
[DisplayName("Securities Transaction Cancellation Request V")]
public record SecuritiesTransactionCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.020.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesTxCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.020.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies a SecuritiesTransactionCancellationRequest message as know by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_EdCB-dE6Ed-BzquC8wXy7w_1971127414")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification11 Identification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_EdCB-tE6Ed-BzquC8wXy7w_-1926064672")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public required TransactionDetails11 Details { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_EdCB-9E6Ed-BzquC8wXy7w_-505950582")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_EdLy8NE6Ed-BzquC8wXy7w_-473628723")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_EdLy8dE6Ed-BzquC8wXy7w_2033219671")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since SecuritiesTransactionCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesTransactionCancellationRequestV01.
