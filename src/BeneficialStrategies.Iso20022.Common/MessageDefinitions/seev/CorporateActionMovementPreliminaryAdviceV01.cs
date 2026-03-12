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
/// This record is an implementation of the seev.035.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdvice message to an account owner or its designated agent to pre-advise upcoming posting or reversal of securities and/or cash postings.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_Td_rSdEwEd-BzquC8wXy7w_1611787017")]
[DisplayName("Corporate Action Movement Preliminary Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementPreliminaryAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.035.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.035.001.01";
    
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
    /// Constructs a CorporateActionMovementPreliminaryAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceV01( DocumentIdentification11 reqIdentification,CorporateActionPreliminaryAdviceType1 reqMovementPreliminaryAdviceGeneralInformation,CorporateActionGeneralInformation3 reqCorporateActionGeneralInformation,AccountIdentification7Choice_ reqAccountDetails )
    {
        Identification = reqIdentification;
        MovementPreliminaryAdviceGeneralInformation = reqMovementPreliminaryAdviceGeneralInformation;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies a CorporateActionMovementPreliminaryAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_Td_rStEwEd-BzquC8wXy7w_-1401758896")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification11 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification11 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification11 Identification { get; init; } 
    #else
    public DocumentIdentification11 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the movement preliminary advice document.
    /// </summary>
    [IsoId("_Td_rS9EwEd-BzquC8wXy7w_993770368")]
    [DisplayName("Movement Preliminary Advice General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntPrlimryAdvcGnlInf")]
    #endif
    [IsoXmlTag("MvmntPrlimryAdvcGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionPreliminaryAdviceType1 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionPreliminaryAdviceType1 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPreliminaryAdviceType1 MovementPreliminaryAdviceGeneralInformation { get; init; } 
    #else
    public CorporateActionPreliminaryAdviceType1 MovementPreliminaryAdviceGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_TeI1MNEwEd-BzquC8wXy7w_-387727187")]
    [DisplayName("Previous Movement Preliminary Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsMvmntPrlimryAdvcId")]
    #endif
    [IsoXmlTag("PrvsMvmntPrlimryAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification15? PreviousMovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification15? PreviousMovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification15? PreviousMovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_TeI1MdEwEd-BzquC8wXy7w_-1346344232")]
    [DisplayName("Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnId")]
    #endif
    [IsoXmlTag("NtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification15? NotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification15? NotificationIdentification { get; init; } 
    #else
    public DocumentIdentification15? NotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement confirmation document.
    /// </summary>
    [IsoId("_TeI1MtEwEd-BzquC8wXy7w_-636936703")]
    [DisplayName("Movement Confirmation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntConfId")]
    #endif
    [IsoXmlTag("MvmntConfId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification15? MovementConfirmationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification15? MovementConfirmationIdentification { get; init; } 
    #else
    public DocumentIdentification15? MovementConfirmationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_TeI1M9EwEd-BzquC8wXy7w_-988020441")]
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
    [IsoId("_TeI1NNEwEd-BzquC8wXy7w_-576128180")]
    [DisplayName("Other Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrDocId")]
    #endif
    [IsoXmlTag("OthrDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification13? OtherDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification13? OtherDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification13? OtherDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of an other corporate action event that needs to be closely linked to the processing of the event notified in this document.
    /// </summary>
    [IsoId("_TeI1NdEwEd-BzquC8wXy7w_1397891250")]
    [DisplayName("Events Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkg")]
    #endif
    [IsoXmlTag("EvtsLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventReference1? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventReference1? EventsLinkage { get; init; } 
    #else
    public CorporateActionEventReference1? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the reversal.
    /// </summary>
    [IsoId("_TeI1NtEwEd-BzquC8wXy7w_1632045745")]
    [DisplayName("Reversal Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsn")]
    #endif
    [IsoXmlTag("RvslRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionReversalReason1? ReversalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionReversalReason1? ReversalReason { get; init; } 
    #else
    public CorporateActionReversalReason1? ReversalReason { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TeI1N9EwEd-BzquC8wXy7w_1471771489")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation3 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation3 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation3 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation3 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_TeSmMNEwEd-BzquC8wXy7w_-1655864801")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification7Choice_ AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification7Choice_ AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification7Choice_ AccountDetails { get; init; } 
    #else
    public AccountIdentification7Choice_ AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_TeSmMdEwEd-BzquC8wXy7w_-1840834741")]
    [DisplayName("Corporate Action Movement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnMvmntDtls")]
    #endif
    [IsoXmlTag("CorpActnMvmntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption10? CorporateActionMovementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption10? CorporateActionMovementDetails { get; init; } 
    #else
    public CorporateActionOption10? CorporateActionMovementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TeSmMtEwEd-BzquC8wXy7w_248559991")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative6? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative6? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative6? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_TeSmM9EwEd-BzquC8wXy7w_994766215")]
    [DisplayName("Message Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgOrgtr")]
    #endif
    [IsoXmlTag("MsgOrgtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? MessageOriginator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? MessageOriginator { get; init; } 
    #else
    public PartyIdentification10Choice_? MessageOriginator { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is the final destination of the message, if other than the receiver.
    /// </summary>
    [IsoId("_TeSmNNEwEd-BzquC8wXy7w_1065877947")]
    [DisplayName("Message Recipient")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRcpt")]
    #endif
    [IsoXmlTag("MsgRcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? MessageRecipient { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? MessageRecipient { get; init; } 
    #else
    public PartyIdentification10Choice_? MessageRecipient { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_TeSmNdEwEd-BzquC8wXy7w_1118516589")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TeSmNtEwEd-BzquC8wXy7w_1390957641")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_TeSmN9EwEd-BzquC8wXy7w_1432514283")]
    [DisplayName("Sub Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPngAgt")]
    #endif
    [IsoXmlTag("SubPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_TecXMNEwEd-BzquC8wXy7w_686181954")]
    [DisplayName("Registrar")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regar")]
    #endif
    [IsoXmlTag("Regar")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? Registrar { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? Registrar { get; init; } 
    #else
    public PartyIdentification10Choice_? Registrar { get; set; } 
    #endif
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_TecXMdEwEd-BzquC8wXy7w_-157068985")]
    [DisplayName("Reselling Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsellngAgt")]
    #endif
    [IsoXmlTag("RsellngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? ResellingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? ResellingAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? ResellingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_TecXMtEwEd-BzquC8wXy7w_-920819365")]
    [DisplayName("Physical Securities Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysSctiesAgt")]
    #endif
    [IsoXmlTag("PhysSctiesAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? PhysicalSecuritiesAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? PhysicalSecuritiesAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? PhysicalSecuritiesAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution who acts on behalf of an out of town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_TecXM9EwEd-BzquC8wXy7w_-1003015589")]
    [DisplayName("Drop Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrpAgt")]
    #endif
    [IsoXmlTag("DrpAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? DropAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? DropAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? DropAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_TecXNNEwEd-BzquC8wXy7w_-145987139")]
    [DisplayName("Solicitation Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnAgt")]
    #endif
    [IsoXmlTag("SlctnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? SolicitationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? SolicitationAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? SolicitationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_TecXNdEwEd-BzquC8wXy7w_-117359460")]
    [DisplayName("Information Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfAgt")]
    #endif
    [IsoXmlTag("InfAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification10Choice_? InformationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_? InformationAgent { get; init; } 
    #else
    public PartyIdentification10Choice_? InformationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TecXNtEwEd-BzquC8wXy7w_733410265")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension2? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension2? Extension { get; init; } 
    #else
    public Extension2? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CorporateActionMovementPreliminaryAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceV01.

