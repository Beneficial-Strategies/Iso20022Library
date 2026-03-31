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
/// This record is an implementation of the seev.035.002.14 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementPreliminaryAdvice message is sent by an account servicer to an account owner or its designated agent:
/// - to advise about the final eligible balance and entitlements and,
/// - to pre-advise an upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|The CorporateActionMovementPreliminaryAdvice message is sent by an account servicer to an account owner or its designated agent:|- to advise about the final eligible balance and entitlements and,|- to pre-advise an upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH)."
)]
[IsoId("_TsuZM199Ee262vCSVgjImg")]
[DisplayName("Corporate Action Movement Preliminary Advice 002 V")]
public record CorporateActionMovementPreliminaryAdvice002V14 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.002.14";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.002.14";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_TsuZTF99Ee262vCSVgjImg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_TsuZTl99Ee262vCSVgjImg")]
    [DisplayName("Movement Preliminary Advice General Information")]
    [IsoXmlTag("MvmntPrlimryAdvcGnlInf")]
    public required CorporateActionPreliminaryAdviceType3 MovementPreliminaryAdviceGeneralInformation { get; init; }

    /// <summary>
    /// Identification of the previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_TsuZUF99Ee262vCSVgjImg")]
    [DisplayName("Previous Movement Preliminary Advice Identification")]
    [IsoXmlTag("PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification37? PreviousMovementPreliminaryAdviceIdentification { get; init; }

    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_TsuZUl99Ee262vCSVgjImg")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public DocumentIdentification37? NotificationIdentification { get; init; }

    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_TsuZVF99Ee262vCSVgjImg")]
    [DisplayName("Movement Confirmation Identification")]
    [IsoXmlTag("MvmntConfId")]
    public DocumentIdentification37? MovementConfirmationIdentification { get; init; }

    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_TsuZVl99Ee262vCSVgjImg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification17? InstructionIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_TsuZWF99Ee262vCSVgjImg")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification38? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_TsuZWl99Ee262vCSVgjImg")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference4? EventsLinkage { get; init; }

    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_TsuZXF99Ee262vCSVgjImg")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public CorporateActionReversalReason6? ReversalReason { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TsuZXl99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation168 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_TsuZYF99Ee262vCSVgjImg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification52Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_TsuZYl99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction77? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_TsuZZF99Ee262vCSVgjImg")]
    [DisplayName("Corporate Action Movement Details")]
    [IsoXmlTag("CorpActnMvmntDtls")]
    public CorporateActionOption214? CorporateActionMovementDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TsuZZl99Ee262vCSVgjImg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative53? AdditionalInformation { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TsuZaF99Ee262vCSVgjImg")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification151Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TsuZal99Ee262vCSVgjImg")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification137Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TsuZbF99Ee262vCSVgjImg")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification137Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_TsuZbl99Ee262vCSVgjImg")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification137Choice_? Registrar { get; init; }

    /// <summary>
    /// Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_TsuZcF99Ee262vCSVgjImg")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification137Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_TsuZcl99Ee262vCSVgjImg")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_TsuZdF99Ee262vCSVgjImg")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification137Choice_? DropAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_TsuZdl99Ee262vCSVgjImg")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification137Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_TsuZeF99Ee262vCSVgjImg")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification137Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TsuZel99Ee262vCSVgjImg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }

    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_TsuZfF99Ee262vCSVgjImg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification151Choice_? Issuer { get; init; }

    /// <summary>
    /// Party making the offer and which is different from the issuing company.
    /// </summary>
    [IsoId("_TsuZfl99Ee262vCSVgjImg")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public PartyIdentification151Choice_? Offeror { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.
    /// </summary>
    [IsoId("_TsuZgF99Ee262vCSVgjImg")]
    [DisplayName("Transfer Agent")]
    [IsoXmlTag("TrfAgt")]
    public PartyIdentification151Choice_? TransferAgent { get; init; }
}

// Since CorporateActionMovementPreliminaryAdvice002V14Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdvice002V14.
