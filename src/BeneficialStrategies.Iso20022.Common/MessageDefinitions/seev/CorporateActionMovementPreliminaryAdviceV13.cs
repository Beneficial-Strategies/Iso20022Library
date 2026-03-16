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
/// This record is an implementation of the seev.035.001.13 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementPreliminaryAdvice message is sent by an account servicer to an account owner or its designated agent to pre-advise an upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(
    @"Scope|The CorporateActionMovementPreliminaryAdvice message is sent by an account servicer to an account owner or its designated agent to pre-advise an upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH)."
)]
[IsoId("_yg7BARbHEeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Movement Preliminary Advice V")]
public record CorporateActionMovementPreliminaryAdviceV13 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.001.13";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.13";

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
    [IsoId("_yg7BFxbHEeyroI8qKgB7Mg")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; }

    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_yg7BGRbHEeyroI8qKgB7Mg")]
    [DisplayName("Movement Preliminary Advice General Information")]
    [IsoXmlTag("MvmntPrlimryAdvcGnlInf")]
    public required CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; }

    /// <summary>
    /// Identification of the previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_yg7BGxbHEeyroI8qKgB7Mg")]
    [DisplayName("Previous Movement Preliminary Advice Identification")]
    [IsoXmlTag("PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification31? PreviousMovementPreliminaryAdviceIdentification { get; init; }

    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_yg7BHRbHEeyroI8qKgB7Mg")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public DocumentIdentification31? NotificationIdentification { get; init; }

    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_yg7BHxbHEeyroI8qKgB7Mg")]
    [DisplayName("Movement Confirmation Identification")]
    [IsoXmlTag("MvmntConfId")]
    public DocumentIdentification31? MovementConfirmationIdentification { get; init; }

    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_yg7BIRbHEeyroI8qKgB7Mg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; }

    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_yg7BIxbHEeyroI8qKgB7Mg")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification32? OtherDocumentIdentification { get; init; }

    /// <summary>
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_yg7BJRbHEeyroI8qKgB7Mg")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference3? EventsLinkage { get; init; }

    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_yg7BJxbHEeyroI8qKgB7Mg")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public CorporateActionReversalReason3? ReversalReason { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_yg7BKRbHEeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation163 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_yg7BKxbHEeyroI8qKgB7Mg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification47Choice_ AccountDetails { get; init; }

    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_yg7BLRbHEeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction61? CorporateActionDetails { get; init; }

    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_yg7BLxbHEeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action Movement Details")]
    [IsoXmlTag("CorpActnMvmntDtls")]
    public CorporateActionOption194? CorporateActionMovementDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_yg7BMRbHEeyroI8qKgB7Mg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative52? AdditionalInformation { get; init; }

    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_yg7BMxbHEeyroI8qKgB7Mg")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification129Choice_? IssuerAgent { get; init; }

    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_yg7BNRbHEeyroI8qKgB7Mg")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification120Choice_? PayingAgent { get; init; }

    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_yg7BNxbHEeyroI8qKgB7Mg")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification120Choice_? SubPayingAgent { get; init; }

    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_yg7BORbHEeyroI8qKgB7Mg")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification120Choice_? Registrar { get; init; }

    /// <summary>
    /// Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_yg7BOxbHEeyroI8qKgB7Mg")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification120Choice_? ResellingAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_yg7BPRbHEeyroI8qKgB7Mg")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification120Choice_? PhysicalSecuritiesAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_yg7BPxbHEeyroI8qKgB7Mg")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification120Choice_? DropAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_yg7BQRbHEeyroI8qKgB7Mg")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification120Choice_? SolicitationAgent { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_yg7BQxbHEeyroI8qKgB7Mg")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification120Choice_? InformationAgent { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yg7BRRbHEeyroI8qKgB7Mg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }

    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_yg7BRxbHEeyroI8qKgB7Mg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification129Choice_? Issuer { get; init; }

    /// <summary>
    /// Party making the offer and which is different from the issuing company.
    /// </summary>
    [IsoId("_yg7BSRbHEeyroI8qKgB7Mg")]
    [DisplayName("Offeror")]
    [IsoXmlTag("Offerr")]
    public PartyIdentification129Choice_? Offeror { get; init; }

    /// <summary>
    /// Trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.
    /// </summary>
    [IsoId("_yg7BSxbHEeyroI8qKgB7Mg")]
    [DisplayName("Transfer Agent")]
    [IsoXmlTag("TrfAgt")]
    public PartyIdentification129Choice_? TransferAgent { get; init; }
}

// Since CorporateActionMovementPreliminaryAdviceV13Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceV13.
