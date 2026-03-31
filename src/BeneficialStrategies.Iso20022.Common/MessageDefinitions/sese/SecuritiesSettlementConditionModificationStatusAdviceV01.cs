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
/// This record is an implementation of the sese.031.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementConditionsModificationStatusAdvice to an account owner to advise the status of a modification request previously instructed by the account owner.
/// |The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// |Usage
/// A SecuritiesSettlementConditionsModificatioRequest may contain requests on multiple transactions. However, one SecuritiesSettlementConditionsModificationStatusAdvice must be sent per transaction modified unless the SecuritiesSettlementConditionsModificationRequest is rejected as a whole.
/// |The message may also be used to: |
/// - re-send a message previously sent (the sub-function of the message is Duplicate) |
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy) |
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).
/// ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.|.
/// </summary>
[Description(
    @"Scope|An account servicer sends a SecuritiesSettlementConditionsModificationStatusAdvice to an account owner to advise the status of a modification request previously instructed by the account owner.||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|A SecuritiesSettlementConditionsModificatioRequest may contain requests on multiple transactions. However, one SecuritiesSettlementConditionsModificationStatusAdvice must be sent per transaction modified unless the SecuritiesSettlementConditionsModificationRequest is rejected as a whole.			||The message may also be used to: ||- re-send a message previously sent (the sub-function of the message is Duplicate) ||- provide a third party with a copy of a message for information (the sub-function of the message is Copy) ||- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.|."
)]
[IsoId("_1MtSiNE5Ed-BzquC8wXy7w_985101267")]
[DisplayName("Securities Settlement Condition Modification Status Advice V")]
public record SecuritiesSettlementConditionModificationStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.031.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmCondModStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.031.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies a SecuritiesSettlementConditionModificationStatusAdvice message as known by the account servicer.
    /// </summary>
    [IsoId("_1MtSidE5Ed-BzquC8wXy7w_-909459027")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification11 Identification { get; init; }

    /// <summary>
    /// Identification of the SecuritiesSettlementConditionsModificationRequest.
    /// </summary>
    [IsoId("_1MtSitE5Ed-BzquC8wXy7w_686324124")]
    [DisplayName("Request Reference")]
    [IsoXmlTag("ReqRef")]
    public required Identification1 RequestReference { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_1MtSi9E5Ed-BzquC8wXy7w_-444926450")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification13Choice_? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_1M3DgNE5Ed-BzquC8wXy7w_-1178239149")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount13? SafekeepingAccount { get; init; }

    /// <summary>
    /// Details of the request.
    /// </summary>
    [IsoId("_1M3DgdE5Ed-BzquC8wXy7w_1414149203")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public RequestDetails1? RequestDetails { get; init; }

    /// <summary>
    /// Provides details on the processing status of the request.
    /// </summary>
    [IsoId("_1M3DgtE5Ed-BzquC8wXy7w_-14563881")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required ProcessingStatus5Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_1M3Dg9E5Ed-BzquC8wXy7w_-1853560413")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_1M3DhNE5Ed-BzquC8wXy7w_-1768597367")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1M3DhdE5Ed-BzquC8wXy7w_-1483229932")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since SecuritiesSettlementConditionModificationStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementConditionModificationStatusAdviceV01.
