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
/// This record is an implementation of the seev.044.002.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CorporateActionMovementPreliminaryAdviceCancellationAdvice message is sent by an account servicer to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).
/// </summary>
[Description(@"Scope|The CorporateActionMovementPreliminaryAdviceCancellationAdvice message is sent by an account servicer to an account owner or its designated agent to cancel a previously announced CorporateActionMovementPreliminaryAdvice.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate), using the relevant elements in the business application header (BAH).")]
[IsoId("_Ovm4xwVTEeqjd8n6wD9JVw")]
[DisplayName("Corporate Action Movement Preliminary Advice Cancellation Advice 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementPreliminaryAdviceCancellationAdvice002V10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.044.002.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntPrlimryAdvcCxlAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.044.002.10";
    
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
    /// Constructs a CorporateActionMovementPreliminaryAdviceCancellationAdvice002V10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementPreliminaryAdviceCancellationAdvice002V10( DocumentIdentification37 reqMovementPreliminaryAdviceIdentification,CorporateActionGeneralInformation150 reqCorporateActionGeneralInformation,AccountIdentification43Choice_ reqAccountDetails )
    {
        MovementPreliminaryAdviceIdentification = reqMovementPreliminaryAdviceIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_Ovm4zAVTEeqjd8n6wD9JVw")]
    [DisplayName("Movement Preliminary Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntPrlimryAdvcId")]
    #endif
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification37 MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification37 MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification37 MovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification37 MovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_Ovm4zgVTEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation150 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation150 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation150 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation150 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account and the account owner.
    /// </summary>
    [IsoId("_Ovm40AVTEeqjd8n6wD9JVw")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification43Choice_ AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification43Choice_ AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification43Choice_ AccountDetails { get; init; } 
    #else
    public AccountIdentification43Choice_ AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action event.
    /// </summary>
    [IsoId("_Ovm40gVTEeqjd8n6wD9JVw")]
    [DisplayName("Corporate Action Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDtls")]
    #endif
    [IsoXmlTag("CorpActnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateAction48? CorporateActionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateAction48? CorporateActionDetails { get; init; } 
    #else
    public CorporateAction48? CorporateActionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_Ovm41AVTEeqjd8n6wD9JVw")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_Ovm41gVTEeqjd8n6wD9JVw")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_Ovm42AVTEeqjd8n6wD9JVw")]
    [DisplayName("Sub Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPngAgt")]
    #endif
    [IsoXmlTag("SubPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Party/agent responsible for maintaining the register of a security.
    /// </summary>
    [IsoId("_Ovm42gVTEeqjd8n6wD9JVw")]
    [DisplayName("Registrar")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Regar")]
    #endif
    [IsoXmlTag("Regar")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? Registrar { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? Registrar { get; init; } 
    #else
    public PartyIdentification137Choice_? Registrar { get; set; } 
    #endif
    
    /// <summary>
    /// A broker-dealer responsible for reselling to new investors securities (usually bonds) that have been tendered for purchase by their owner.
    /// </summary>
    [IsoId("_Ovm43AVTEeqjd8n6wD9JVw")]
    [DisplayName("Reselling Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsellngAgt")]
    #endif
    [IsoXmlTag("RsellngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? ResellingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? ResellingAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? ResellingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to accept presentations of instruments, usually bonds, for transfer and or exchange.
    /// </summary>
    [IsoId("_Ovm43gVTEeqjd8n6wD9JVw")]
    [DisplayName("Physical Securities Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhysSctiesAgt")]
    #endif
    [IsoXmlTag("PhysSctiesAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? PhysicalSecuritiesAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution that acts on behalf of an out-of-town agent or event agent where securities can be delivered in person.
    /// </summary>
    [IsoId("_Ovm44AVTEeqjd8n6wD9JVw")]
    [DisplayName("Drop Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrpAgt")]
    #endif
    [IsoXmlTag("DrpAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? DropAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? DropAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? DropAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an issuer to maintain records of investors and account balances and transactions for the consent of a material change.
    /// </summary>
    [IsoId("_Ovm44gVTEeqjd8n6wD9JVw")]
    [DisplayName("Solicitation Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SlctnAgt")]
    #endif
    [IsoXmlTag("SlctnAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? SolicitationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? SolicitationAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? SolicitationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// A trust company, bank or similar financial institution assigned by an Issuer to provide information and copies of the offering documentation.
    /// </summary>
    [IsoId("_Ovm45AVTEeqjd8n6wD9JVw")]
    [DisplayName("Information Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfAgt")]
    #endif
    [IsoXmlTag("InfAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification137Choice_? InformationAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification137Choice_? InformationAgent { get; init; } 
    #else
    public PartyIdentification137Choice_? InformationAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Ovm45gVTEeqjd8n6wD9JVw")]
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


// Since CorporateActionMovementPreliminaryAdviceCancellationAdvice002V10Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementPreliminaryAdviceCancellationAdvice002V10.

