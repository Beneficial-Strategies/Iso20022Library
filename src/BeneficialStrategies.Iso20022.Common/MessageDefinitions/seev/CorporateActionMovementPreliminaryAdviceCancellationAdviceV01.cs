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
[Description(@"Scope|An account servicer sends the CorporateActionMovementPreliminaryAdviceCancellationAdvice message to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_TdGTb9EwEd-BzquC8wXy7w_-2109268436")]
[DisplayName("Corporate Action Movement Preliminary Advice Cancellation Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementPreliminaryAdviceCancellationAdviceV01 : IOuterRecord
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionMovementPreliminaryAdviceCancellationAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceCancellationAdviceV01( DocumentIdentification11 reqIdentification,CorporateActionProcessingStatus1Choice_ reqCancellationAdviceGeneralInformation,DocumentIdentification15 reqMovementPreliminaryAdviceIdentification,CorporateActionGeneralInformation8 reqCorporateActionGeneralInformation,AccountIdentification6Choice_ reqAccountDetails )
    {
        Identification = reqIdentification;
        CancellationAdviceGeneralInformation = reqCancellationAdviceGeneralInformation;
        MovementPreliminaryAdviceIdentification = reqMovementPreliminaryAdviceIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information that unambiguously identifies a CorporateActionMovementPreliminaryAdviceCancellationAdvice message as know by the account servicer.
    /// </summary>
    [IsoId("_TdGTcNEwEd-BzquC8wXy7w_-1515716832")]
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
    /// Specifies the status of the details of the event.
    /// </summary>
    [IsoId("_TdQEYNEwEd-BzquC8wXy7w_-1810962523")]
    [DisplayName("Cancellation Advice General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlAdvcGnlInf")]
    #endif
    [IsoXmlTag("CxlAdvcGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionProcessingStatus1Choice_ CancellationAdviceGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionProcessingStatus1Choice_ CancellationAdviceGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionProcessingStatus1Choice_ CancellationAdviceGeneralInformation { get; init; } 
    #else
    public CorporateActionProcessingStatus1Choice_ CancellationAdviceGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_TdQEYdEwEd-BzquC8wXy7w_1841151509")]
    [DisplayName("Movement Preliminary Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntPrlimryAdvcId")]
    #endif
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification15 MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification15 MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification15 MovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification15 MovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TdQEYtEwEd-BzquC8wXy7w_785105758")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation8 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation8 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation8 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation8 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_TdQEY9EwEd-BzquC8wXy7w_-1784238551")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification6Choice_ AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification6Choice_ AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification6Choice_ AccountDetails { get; init; } 
    #else
    public AccountIdentification6Choice_ AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that originated the message, if other than the sender.
    /// </summary>
    [IsoId("_TdQEZNEwEd-BzquC8wXy7w_-1209038948")]
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
    [IsoId("_TdQEZdEwEd-BzquC8wXy7w_2088855995")]
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
    [IsoId("_TdQEZtEwEd-BzquC8wXy7w_1091783642")]
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
    [IsoId("_TdQEZ9EwEd-BzquC8wXy7w_94711289")]
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
    [IsoId("_TdZOUNEwEd-BzquC8wXy7w_-902361064")]
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
    [IsoId("_TdZOUdEwEd-BzquC8wXy7w_-1899433417")]
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
    [IsoId("_TdZOUtEwEd-BzquC8wXy7w_-595683180")]
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
    [IsoId("_TdZOU9EwEd-BzquC8wXy7w_401389173")]
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
    [IsoId("_TdZOVNEwEd-BzquC8wXy7w_1398461526")]
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
    [IsoId("_TdZOVdEwEd-BzquC8wXy7w_-1592755533")]
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
    [IsoId("_TdZOVtEwEd-BzquC8wXy7w_1705139410")]
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
    [IsoId("_TdZOV9EwEd-BzquC8wXy7w_708067057")]
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


// Since CorporateActionMovementPreliminaryAdviceCancellationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceCancellationAdviceV01.

