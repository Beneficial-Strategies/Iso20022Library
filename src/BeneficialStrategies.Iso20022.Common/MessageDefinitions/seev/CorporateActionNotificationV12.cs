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
/// This record is an implementation of the seev.031.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionNotification message is sent by an account servicer to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.|
/// It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.|
/// It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|The CorporateActionNotification message is sent by an account servicer to an account owner or its designated agent to notify details of a corporate action event and optionally account information, eligible balance and entitlements.||It may also include possible elections or choices available to the account owner. The account servicer can initially send the CorporateActionNotification message as a preliminary advice, subsequently replaced by another CorporateActionNotification message with complete or confirmed information.||It may also be sent to an account owner or its designated agent, to remind of event details and/or of missing or incomplete instructions for a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
[IsoId("_yg7BhxbHEeyroI8qKgB7Mg")]
[DisplayName("Corporate Action Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationV12 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.031.001.12";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.031.001.12";
    
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
    /// Constructs a CorporateActionNotificationV12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotificationV12( CorporateActionNotification5 reqNotificationGeneralInformation,CorporateActionGeneralInformation165 reqCorporateActionGeneralInformation,AccountIdentification47Choice_ reqAccountDetails )
    {
        NotificationGeneralInformation = reqNotificationGeneralInformation;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.
    /// </summary>
    [IsoId("_yg7BtRbHEeyroI8qKgB7Mg")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? Pagination { get; init; } 
    #else
    public Pagination1? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the event notification type, status and contents.
    /// </summary>
    [IsoId("_yg7BtxbHEeyroI8qKgB7Mg")]
    [DisplayName("Notification General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnGnlInf")]
    #endif
    [IsoXmlTag("NtfctnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionNotification5 NotificationGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionNotification5 NotificationGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotification5 NotificationGeneralInformation { get; init; } 
    #else
    public CorporateActionNotification5 NotificationGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the previously sent notification document.
    /// </summary>
    [IsoId("_yg7BuRbHEeyroI8qKgB7Mg")]
    [DisplayName("Previous Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsNtfctnId")]
    #endif
    [IsoXmlTag("PrvsNtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification31? PreviousNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification31? PreviousNotificationIdentification { get; init; } 
    #else
    public DocumentIdentification31? PreviousNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_yg7BuxbHEeyroI8qKgB7Mg")]
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
    [IsoId("_yg7BvRbHEeyroI8qKgB7Mg")]
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
    /// Identification of another corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_yg7BvxbHEeyroI8qKgB7Mg")]
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
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_yg7BwRbHEeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation165 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation165 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation165 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation165 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_yg7BwxbHEeyroI8qKgB7Mg")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification47Choice_ AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification47Choice_ AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification47Choice_ AccountDetails { get; init; } 
    #else
    public AccountIdentification47Choice_ AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details on rights credited to the account as for example trading period, expiry date, renounceability.
    /// </summary>
    [IsoId("_yg7BxRbHEeyroI8qKgB7Mg")]
    [DisplayName("Intermediate Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmdtScty")]
    #endif
    [IsoXmlTag("IntrmdtScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributes110? IntermediateSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributes110? IntermediateSecurity { get; init; } 
    #else
    public FinancialInstrumentAttributes110? IntermediateSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_yg7BxxbHEeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction60? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction60? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction60? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_yg7ByRbHEeyroI8qKgB7Mg")]
    [DisplayName("Corporate Action Option Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnOptnDtls")]
    #endif
    [IsoXmlTag("CorpActnOptnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption193? CorporateActionOptionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption193? CorporateActionOptionDetails { get; init; } 
    #else
    public CorporateActionOption193? CorporateActionOptionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the event.
    /// </summary>
    [IsoId("_yg7ByxbHEeyroI8qKgB7Mg")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative51? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative51? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative51? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_yg7BzRbHEeyroI8qKgB7Mg")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification129Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_yg7BzxbHEeyroI8qKgB7Mg")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_yg7B0RbHEeyroI8qKgB7Mg")]
    [DisplayName("Sub Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPngAgt")]
    #endif
    [IsoXmlTag("SubPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of the security.
    /// </summary>
    [IsoId("_yg7B0xbHEeyroI8qKgB7Mg")]
    [DisplayName("Registrar")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regar")]
    #endif
    [IsoXmlTag("Regar")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? Registrar { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? Registrar { get; init; } 
    #else
    public PartyIdentification120Choice_? Registrar { get; set; } 
    #endif
    
    /// <summary>
    /// Broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_yg7B1RbHEeyroI8qKgB7Mg")]
    [DisplayName("Reselling Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsellngAgt")]
    #endif
    [IsoXmlTag("RsellngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? ResellingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? ResellingAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? ResellingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_yg7B1xbHEeyroI8qKgB7Mg")]
    [DisplayName("Physical Securities Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysSctiesAgt")]
    #endif
    [IsoXmlTag("PhysSctiesAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? PhysicalSecuritiesAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? PhysicalSecuritiesAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? PhysicalSecuritiesAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_yg7B2RbHEeyroI8qKgB7Mg")]
    [DisplayName("Drop Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrpAgt")]
    #endif
    [IsoXmlTag("DrpAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? DropAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? DropAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? DropAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_yg7B2xbHEeyroI8qKgB7Mg")]
    [DisplayName("Solicitation Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnAgt")]
    #endif
    [IsoXmlTag("SlctnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? SolicitationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? SolicitationAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? SolicitationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_yg7B3RbHEeyroI8qKgB7Mg")]
    [DisplayName("Information Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfAgt")]
    #endif
    [IsoXmlTag("InfAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification120Choice_? InformationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification120Choice_? InformationAgent { get; init; } 
    #else
    public PartyIdentification120Choice_? InformationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the financial instrument.
    /// </summary>
    [IsoId("_yg7B3xbHEeyroI8qKgB7Mg")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? Issuer { get; init; } 
    #else
    public PartyIdentification129Choice_? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Party making the offer and which is different from the issuing company.
    /// </summary>
    [IsoId("_yg7B4RbHEeyroI8qKgB7Mg")]
    [DisplayName("Offeror")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Offerr")]
    #endif
    [IsoXmlTag("Offerr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? Offeror { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? Offeror { get; init; } 
    #else
    public PartyIdentification129Choice_? Offeror { get; set; } 
    #endif
    
    /// <summary>
    /// Trust company, bank or similar financial institution appointed by a fund management company to maintain records of investors and account balances. The transfer agent records transactions, including subscriptions, redemptions, switches, transfers, and re-registrations.
    /// </summary>
    [IsoId("_yg7B4xbHEeyroI8qKgB7Mg")]
    [DisplayName("Transfer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfAgt")]
    #endif
    [IsoXmlTag("TrfAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification129Choice_? TransferAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification129Choice_? TransferAgent { get; init; } 
    #else
    public PartyIdentification129Choice_? TransferAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yg7B5RbHEeyroI8qKgB7Mg")]
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


// Since CorporateActionNotificationV12Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionNotificationV12.

