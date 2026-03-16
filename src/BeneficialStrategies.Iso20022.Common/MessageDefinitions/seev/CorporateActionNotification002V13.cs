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
/// This record is an implementation of the seev.031.002.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionNotification message is sent by an account servicer to an account owner or its designated agent to notify details of a corporate action event and optionally account information and preliminary information about eligible balance and entitlements.|
/// It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.|
/// It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|The CorporateActionNotification message is sent by an account servicer to an account owner or its designated agent to notify details of a corporate action event and optionally account information and preliminary information about eligible balance and entitlements.||It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.||It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH)."
)]
[IsoId("_YXNLU199Ee262vCSVgjImg")]
[DisplayName("Corporate Action Notification 002 V")]
public record CorporateActionNotification002V13 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.031.002.13";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.002.13";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.
    /// </summary>
    [IsoId("_YXNLpF99Ee262vCSVgjImg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// General information about the event notification type, status and contents.
    /// </summary>
    [IsoId("_YXNLpl99Ee262vCSVgjImg")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public required CorporateActionNotification8 NotificationGeneralInformation { get; init; }

    /// <summary>
    /// Identification of the previously sent notification document.
    /// </summary>
    [IsoId("_YXNLqF99Ee262vCSVgjImg")]
    [DisplayName("Previous Notification Identification")]
    [IsoXmlTag("PrvsNtfctnId")]
    public DocumentIdentification37? PreviousNotificationIdentification { get; init; }

    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_YXNLql99Ee262vCSVgjImg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification17? InstructionIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_YXNLrF99Ee262vCSVgjImg")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_YXNLrl99Ee262vCSVgjImg")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_YXNLsF99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation170 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_YXNLsl99Ee262vCSVgjImg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification57Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Details on rights credited to the account as for example trading period, expiry date, renounceability.
    /// </summary>
    [IsoId("_YXNLtF99Ee262vCSVgjImg")]
    [DisplayName("Intermediate Security")]
    [IsoXmlTag("IntrmdtScty")]
    public FinancialInstrumentAttributes117? IntermediateSecurity { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_YXNLtl99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction79? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_YXNLuF99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action Option Details")]
    [IsoXmlTag("CorpActnOptnDtls")]
    public CorporateActionOption216? CorporateActionOptionDetails { get; init; }

    /// <summary>
    /// Additional information on the event.
    /// </summary>
    [IsoId("_YXNLul99Ee262vCSVgjImg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative55? AdditionalInformation { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_YXNLvF99Ee262vCSVgjImg")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification151Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_YXNLvl99Ee262vCSVgjImg")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification137Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_YXNLwF99Ee262vCSVgjImg")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification137Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of the security.
    /// </summary>
    [IsoId("_YXNLwl99Ee262vCSVgjImg")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification137Choice_? Registrar { get; init; }

    /// <summary>
    /// Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_YXNLxF99Ee262vCSVgjImg")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification137Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_YXNLxl99Ee262vCSVgjImg")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_YXNLyF99Ee262vCSVgjImg")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification137Choice_? DropAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_YXNLyl99Ee262vCSVgjImg")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification137Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_YXNLzF99Ee262vCSVgjImg")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification137Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_YXNLzl99Ee262vCSVgjImg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification151Choice_? Issuer { get; init; }

    /// <summary>
    /// Party making the offer and which is different from the issuing company.
    /// </summary>
    [IsoId("_YXNL0F99Ee262vCSVgjImg")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public PartyIdentification151Choice_? Offeror { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.
    /// </summary>
    [IsoId("_YXNL0l99Ee262vCSVgjImg")]
    [DisplayName("Transfer Agent")]
    [IsoXmlTag("TrfAgt")]
    public PartyIdentification151Choice_? TransferAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_YXNL1F99Ee262vCSVgjImg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CorporateActionNotification002V13Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionNotification002V13.
