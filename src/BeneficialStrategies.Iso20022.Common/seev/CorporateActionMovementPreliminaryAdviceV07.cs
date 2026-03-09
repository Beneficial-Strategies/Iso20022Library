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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.035.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).")]
[IsoId("_Rc5pJTm_EeWENZE2jGFgGw")]
[DisplayName("Corporate Action Movement Preliminary Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementPreliminaryAdviceV07 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.001.07";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementPreliminaryAdviceV07 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceV07( CorporateActionPreliminaryAdviceType2 reqMovementPreliminaryAdviceGeneralInformation,CorporateActionGeneralInformation84 reqCorporateActionGeneralInformation,AccountIdentification32Choice_ reqAccountDetails )
    {
        MovementPreliminaryAdviceGeneralInformation = reqMovementPreliminaryAdviceGeneralInformation;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts preliminary advice is to continue or that the message is the last page of the multi-parts preliminary advice.
    /// </summary>
    [IsoId("_Rc5pNTm_EeWENZE2jGFgGw")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? Pagination { get; init; } 
    #else
    public Pagination? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_Rc5pNzm_EeWENZE2jGFgGw")]
    [DisplayName("Movement Preliminary Advice General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntPrlimryAdvcGnlInf")]
    #endif
    [IsoXmlTag("MvmntPrlimryAdvcGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    #else
    public CorporateActionPreliminaryAdviceType2 MovementPreliminaryAdviceGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_Rc5pOTm_EeWENZE2jGFgGw")]
    [DisplayName("Previous Movement Preliminary Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsMvmntPrlimryAdvcId")]
    #endif
    [IsoXmlTag("PrvsMvmntPrlimryAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification31? PreviousMovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31? PreviousMovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification31? PreviousMovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_Rc5pOzm_EeWENZE2jGFgGw")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification31? NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31? NotificationIdentification { get; init; } 
    #else
    public DocumentIdentification31? NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_Rc5pPTm_EeWENZE2jGFgGw")]
    [DisplayName("Movement Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntConfId")]
    #endif
    [IsoXmlTag("MvmntConfId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification31? MovementConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31? MovementConfirmationIdentification { get; init; } 
    #else
    public DocumentIdentification31? MovementConfirmationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_Rc5pPzm_EeWENZE2jGFgGw")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification9? InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification9? InstructionIdentification { get; init; } 
    #else
    public DocumentIdentification9? InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of other documents as well as the document number.
    /// </summary>
    [IsoId("_Rc5pQTm_EeWENZE2jGFgGw")]
    [DisplayName("Other Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDocId")]
    #endif
    [IsoXmlTag("OthrDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification32? OtherDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification32? OtherDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification32? OtherDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_Rc5pQzm_EeWENZE2jGFgGw")]
    [DisplayName("Events Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkg")]
    #endif
    [IsoXmlTag("EvtsLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventReference3? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventReference3? EventsLinkage { get; init; } 
    #else
    public CorporateActionEventReference3? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_Rc5pRTm_EeWENZE2jGFgGw")]
    [DisplayName("Reversal Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsn")]
    #endif
    [IsoXmlTag("RvslRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionReversalReason3? ReversalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionReversalReason3? ReversalReason { get; init; } 
    #else
    public CorporateActionReversalReason3? ReversalReason { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_Rc5pRzm_EeWENZE2jGFgGw")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation84 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation84 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation84 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation84 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_Rc5pSTm_EeWENZE2jGFgGw")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification32Choice_ AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification32Choice_ AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification32Choice_ AccountDetails { get; init; } 
    #else
    public AccountIdentification32Choice_ AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_Rc5pSzm_EeWENZE2jGFgGw")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction32? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction32? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction32? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_Rc5pTTm_EeWENZE2jGFgGw")]
    [DisplayName("Corporate Action Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption115? CorporateActionMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption115? CorporateActionMovementDetails { get; init; } 
    #else
    public CorporateActionOption115? CorporateActionMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_Rc5pTzm_EeWENZE2jGFgGw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative28? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative28? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative28? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_Rc5pUTm_EeWENZE2jGFgGw")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_Rc5pUzm_EeWENZE2jGFgGw")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_Rc5pVTm_EeWENZE2jGFgGw")]
    [DisplayName("Sub Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPngAgt")]
    #endif
    [IsoXmlTag("SubPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_Rc5pVzm_EeWENZE2jGFgGw")]
    [DisplayName("Registrar")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regar")]
    #endif
    [IsoXmlTag("Regar")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? Registrar { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? Registrar { get; init; } 
    #else
    public PartyIdentification71Choice_? Registrar { get; set; } 
    #endif
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_Rc5pWTm_EeWENZE2jGFgGw")]
    [DisplayName("Reselling Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsellngAgt")]
    #endif
    [IsoXmlTag("RsellngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? ResellingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? ResellingAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? ResellingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_Rc5pWzm_EeWENZE2jGFgGw")]
    [DisplayName("Physical Securities Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysSctiesAgt")]
    #endif
    [IsoXmlTag("PhysSctiesAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? PhysicalSecuritiesAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? PhysicalSecuritiesAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? PhysicalSecuritiesAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_Rc5pXTm_EeWENZE2jGFgGw")]
    [DisplayName("Drop Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrpAgt")]
    #endif
    [IsoXmlTag("DrpAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? DropAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? DropAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? DropAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_Rc5pXzm_EeWENZE2jGFgGw")]
    [DisplayName("Solicitation Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnAgt")]
    #endif
    [IsoXmlTag("SlctnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? SolicitationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? SolicitationAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? SolicitationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_Rc5pYTm_EeWENZE2jGFgGw")]
    [DisplayName("Information Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfAgt")]
    #endif
    [IsoXmlTag("InfAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification71Choice_? InformationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification71Choice_? InformationAgent { get; init; } 
    #else
    public PartyIdentification71Choice_? InformationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Rc5pYzm_EeWENZE2jGFgGw")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CorporateActionMovementPreliminaryAdviceV07Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceV07.

