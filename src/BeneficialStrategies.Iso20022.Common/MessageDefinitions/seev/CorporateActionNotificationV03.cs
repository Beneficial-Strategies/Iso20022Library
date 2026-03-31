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
/// This record is an implementation of the seev.031.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionNotification message to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements. It may also include possible elections or choices available to the account owner.
/// The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.
/// It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(
    @"Scope|An account servicer sends the CorporateActionNotification message to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements. It may also include possible elections or choices available to the account owner.|The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.|It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”."
)]
[IsoId("_nn6bcfmMEeC_eLZALo-S0A")]
[DisplayName("Corporate Action Notification V")]
public record CorporateActionNotificationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.031.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts notification is to continue or that the message is the last page of the multi-parts notification.
    /// </summary>
    [IsoId("_QOuMlfo-EeCJ3pjIW8rLMQ")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination? Pagination { get; init; }

    /// <summary>
    /// General information about the event notification type, status and contents.
    /// </summary>
    [IsoId("_nn6bvfmMEeC_eLZALo-S0A")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public required CorporateActionNotification3 NotificationGeneralInformation { get; init; }

    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_nn6bwfmMEeC_eLZALo-S0A")]
    [DisplayName("Previous Notification Identification")]
    [IsoXmlTag("PrvsNtfctnId")]
    public DocumentIdentification15? PreviousNotificationIdentification { get; init; }

    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_nn6bxfmMEeC_eLZALo-S0A")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_nn6byfmMEeC_eLZALo-S0A")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification13? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_nn6bzfmMEeC_eLZALo-S0A")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference1? EventsLinkage { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_nn6b0fmMEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation37 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_nn6b1fmMEeC_eLZALo-S0A")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification18Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Provides details on rights credited to the account as for instance trading period, expiry date, renounceability.
    /// </summary>
    [IsoId("_nn6b2fmMEeC_eLZALo-S0A")]
    [DisplayName("Intermediate Security")]
    [IsoXmlTag("IntrmdtScty")]
    public FinancialInstrumentAttributes17? IntermediateSecurity { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_nn6b3fmMEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction7? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_nn6b4fmMEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action Option Details")]
    [IsoXmlTag("CorpActnOptnDtls")]
    public CorporateActionOption36? CorporateActionOptionDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_nn6b5fmMEeC_eLZALo-S0A")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative11? AdditionalInformation { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_nn6b6fmMEeC_eLZALo-S0A")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification47Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_nn6b7fmMEeC_eLZALo-S0A")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification47Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_nn6b8fmMEeC_eLZALo-S0A")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification47Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_nn6b9fmMEeC_eLZALo-S0A")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification47Choice_? Registrar { get; init; }

    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_nn6b-fmMEeC_eLZALo-S0A")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification47Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_nn6b_fmMEeC_eLZALo-S0A")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification47Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_nn6cAfmMEeC_eLZALo-S0A")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification47Choice_? DropAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_nn6cBfmMEeC_eLZALo-S0A")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification47Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_nn6cCfmMEeC_eLZALo-S0A")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification47Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nn6cDfmMEeC_eLZALo-S0A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionNotificationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionNotificationV03.
