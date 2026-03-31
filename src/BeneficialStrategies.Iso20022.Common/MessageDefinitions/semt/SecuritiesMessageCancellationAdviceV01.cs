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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.020.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// Usage
/// The previously sent message may be:
/// - a securities settlement transaction confirmation
/// - a report (transactions, pending transactions, allegements, accounting and custody securities balance)
/// - an allegement notification (when sent by mistake or because the counterparty cancelled its instruction)
/// - a portfolio transfer notification
/// - an intra-position movement confirmation
/// - a transaction generation notification
/// The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesMessageCancellationAdvice to an account owner to inform of the cancellation of a securities message previously sent by an account servicer.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.|Usage|The previously sent message may be:|- a securities settlement transaction confirmation|- a report (transactions, pending transactions, allegements, accounting and custody securities balance)|- an allegement notification (when sent by mistake or because the counterparty cancelled its instruction)|- a portfolio transfer notification|- an intra-position movement confirmation|- a transaction generation notification|The previously sent message cannot be a status advice message (any). If a status advice should not have been sent, a new status advice with the correct status should be sent, not a cancellation advice.|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_Mgw7AtFSEd-BzquC8wXy7w_919066709")]
[DisplayName("Securities Message Cancellation Advice V")]
public record SecuritiesMessageCancellationAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.020.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.020.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies a SecuritiesMessageCancellationAdvice message as known by the account servicer.
    /// </summary>
    [IsoId("_Mgw7A9FSEd-BzquC8wXy7w_1371655041")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification11 Identification { get; init; }

    /// <summary>
    /// Details of the transaction.
    /// </summary>
    [IsoId("_Mg6r8NFSEd-BzquC8wXy7w_1715216751")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public required TransactionDetails12 Details { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_Mg6r8dFSEd-BzquC8wXy7w_-90366871")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_Mg6r8tFSEd-BzquC8wXy7w_-97756572")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Mg6r89FSEd-BzquC8wXy7w_1894692884")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since SecuritiesMessageCancellationAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesMessageCancellationAdviceV01.
