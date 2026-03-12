// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.035.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE
/// This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_TpD6HVhBEeSewsfsZR0hxA")]
[DisplayName("Corporate Action Movement Preliminary Advice V")]
public partial record CorporateActionMovementPreliminaryAdviceV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts preliminary advice is to continue or that the message is the last page of the multi-parts preliminary advice.
    /// </summary>
    [IsoId("_TpD6LVhBEeSewsfsZR0hxA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination? Pagination { get; init; } 
    
    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_TpD6L1hBEeSewsfsZR0hxA")]
    [DisplayName("Movement Preliminary Advice General Information")]
    [IsoXmlTag("MvmntPrlimryAdvcGnlInf")]
    public required CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_TpD6MVhBEeSewsfsZR0hxA")]
    [DisplayName("Previous Movement Preliminary Advice Identification")]
    [IsoXmlTag("PrvsMvmntPrlimryAdvcId")]
    public DocumentIdentification15? PreviousMovementPreliminaryAdviceIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_TpD6M1hBEeSewsfsZR0hxA")]
    [DisplayName("Notification Identification")]
    [IsoXmlTag("NtfctnId")]
    public DocumentIdentification15? NotificationIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_TpD6NVhBEeSewsfsZR0hxA")]
    [DisplayName("Movement Confirmation Identification")]
    [IsoXmlTag("MvmntConfId")]
    public DocumentIdentification15? MovementConfirmationIdentification { get; init; } 
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_TpD6N1hBEeSewsfsZR0hxA")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public DocumentIdentification9? InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_TpD6OVhBEeSewsfsZR0hxA")]
    [DisplayName("Other Document Identification")]
    [IsoXmlTag("OthrDocId")]
    public DocumentIdentification13? OtherDocumentIdentification { get; init; } 
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_TpD6O1hBEeSewsfsZR0hxA")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public CorporateActionEventReference1? EventsLinkage { get; init; } 
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_TpD6PVhBEeSewsfsZR0hxA")]
    [DisplayName("Reversal Reason")]
    [IsoXmlTag("RvslRsn")]
    public CorporateActionReversalReason1? ReversalReason { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TpD6P1hBEeSewsfsZR0hxA")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionGeneralInformation69 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_TpD6QVhBEeSewsfsZR0hxA")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required AccountIdentification23Choice_ AccountDetails { get; init; } 
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_TpD6Q1hBEeSewsfsZR0hxA")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public CorporateAction24? CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_TpD6RVhBEeSewsfsZR0hxA")]
    [DisplayName("Corporate Action Movement Details")]
    [IsoXmlTag("CorpActnMvmntDtls")]
    public CorporateActionOption100? CorporateActionMovementDetails { get; init; } 
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TpD6R1hBEeSewsfsZR0hxA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative6? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TpD6SVhBEeSewsfsZR0hxA")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public PartyIdentification40Choice_? IssuerAgent { get; init; } 
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TpD6S1hBEeSewsfsZR0hxA")]
    [DisplayName("Paying Agent")]
    [IsoXmlTag("PngAgt")]
    public PartyIdentification40Choice_? PayingAgent { get; init; } 
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TpD6TVhBEeSewsfsZR0hxA")]
    [DisplayName("Sub Paying Agent")]
    [IsoXmlTag("SubPngAgt")]
    public PartyIdentification40Choice_? SubPayingAgent { get; init; } 
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_TpD6T1hBEeSewsfsZR0hxA")]
    [DisplayName("Registrar")]
    [IsoXmlTag("Regar")]
    public PartyIdentification40Choice_? Registrar { get; init; } 
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_TpD6UVhBEeSewsfsZR0hxA")]
    [DisplayName("Reselling Agent")]
    [IsoXmlTag("RsellngAgt")]
    public PartyIdentification40Choice_? ResellingAgent { get; init; } 
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_TpD6U1hBEeSewsfsZR0hxA")]
    [DisplayName("Physical Securities Agent")]
    [IsoXmlTag("PhysSctiesAgt")]
    public PartyIdentification40Choice_? PhysicalSecuritiesAgent { get; init; } 
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_TpD6VVhBEeSewsfsZR0hxA")]
    [DisplayName("Drop Agent")]
    [IsoXmlTag("DrpAgt")]
    public PartyIdentification40Choice_? DropAgent { get; init; } 
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_TpD6V1hBEeSewsfsZR0hxA")]
    [DisplayName("Solicitation Agent")]
    [IsoXmlTag("SlctnAgt")]
    public PartyIdentification40Choice_? SolicitationAgent { get; init; } 
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_TpD6WVhBEeSewsfsZR0hxA")]
    [DisplayName("Information Agent")]
    [IsoXmlTag("InfAgt")]
    public PartyIdentification40Choice_? InformationAgent { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TpD6W1hBEeSewsfsZR0hxA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since CorporateActionMovementPreliminaryAdviceV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceV06.

