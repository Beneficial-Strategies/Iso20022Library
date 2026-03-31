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
/// This record is an implementation of the seev.044.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_TdGTb9EwEd-BzquC8wXy7w_-2109268436")]
[DisplayName("Corporate Action Movement Preliminary Advice Cancellation Advice V")]
public record CorporateActionMovementPreliminaryAdviceCancellationAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.044.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvcCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.044.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information that unambiguously identifies a CorporateActionMovementPreliminaryAdviceCancellationAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_TdGTcNEwEd-BzquC8wXy7w_-1515716832")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification11 Identification { get; init; }

    /// <summary>
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_TdQEYNEwEd-BzquC8wXy7w_-1810962523")]
    [DisplayName("Cancellation Advice General Information")]
    [IsoXmlTag("CxlAdvcGnlInf")]
    public required CorporateActionProcessingStatus1Choice_ CancellationAdviceGeneralInformation { get; init; }

    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_TdQEYdEwEd-BzquC8wXy7w_1841151509")]
    [DisplayName("Movement Preliminary Advice Identification")]
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    public required DocumentIdentification15 MovementPreliminaryAdviceIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TdQEYtEwEd-BzquC8wXy7w_785105758")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation8 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_TdQEY9EwEd-BzquC8wXy7w_-1784238551")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification6Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_TdQEZNEwEd-BzquC8wXy7w_-1209038948")]
    [DisplayName("Message Originator")]
    [IsoXmlTag("MsgOrgtr")]
    public PartyIdentification10Choice_? MessageOriginator { get; init; }

    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_TdQEZdEwEd-BzquC8wXy7w_2088855995")]
    [DisplayName("Message Recipient")]
    [IsoXmlTag("MsgRcpt")]
    public PartyIdentification10Choice_? MessageRecipient { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TdQEZtEwEd-BzquC8wXy7w_1091783642")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification10Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TdQEZ9EwEd-BzquC8wXy7w_94711289")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification10Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TdZOUNEwEd-BzquC8wXy7w_-902361064")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification10Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_TdZOUdEwEd-BzquC8wXy7w_-1899433417")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification10Choice_? Registrar { get; init; }

    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_TdZOUtEwEd-BzquC8wXy7w_-595683180")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification10Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_TdZOU9EwEd-BzquC8wXy7w_401389173")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification10Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_TdZOVNEwEd-BzquC8wXy7w_1398461526")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification10Choice_? DropAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_TdZOVdEwEd-BzquC8wXy7w_-1592755533")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification10Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_TdZOVtEwEd-BzquC8wXy7w_1705139410")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification10Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TdZOV9EwEd-BzquC8wXy7w_708067057")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension2? Extension { get; init; }
}

// Since CorporateActionMovementPreliminaryAdviceCancellationAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceCancellationAdviceV01.
