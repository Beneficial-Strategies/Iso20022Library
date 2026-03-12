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
/// This record is an implementation of the seev.036.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the CorporateActionMovementConfirmation message to an account owner or its designated agent to confirm posting of securities or cash as a result of a corporate action event.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent (the sub-function of the message is Duplicate),
/// - provide a third party with a copy of a message for information (the sub-function of the message is Copy),
/// - re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),
/// using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|An account servicer sends the CorporateActionMovementConfirmation message to an account owner or its designated agent to confirm posting of securities or cash as a result of a corporate action event.|Usage|The message may also be used to:|- re-send a message previously sent (the sub-function of the message is Duplicate),|- provide a third party with a copy of a message for information (the sub-function of the message is Copy),|- re-send to a third party a copy of a message for information (the sub-function of the message is Copy Duplicate),|using the relevant elements in the business application header (BAH).|ISO 15022 - 20022 COEXISTENCE|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_15PMAfmMEeC_eLZALo-S0A")]
[DisplayName("Corporate Action Movement Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionMovementConfirmationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.036.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CorpActnMvmntConf";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.036.001.03";
    
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
    /// Constructs a CorporateActionMovementConfirmationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionMovementConfirmationV03( CorporateActionGeneralInformation39 reqCorporateActionGeneralInformation,AccountAndBalance16 reqAccountDetails,CorporateActionOption37 reqCorporateActionConfirmationDetails )
    {
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
        CorporateActionConfirmationDetails = reqCorporateActionConfirmationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a previously sent notification document.
    /// </summary>
    [IsoId("_15PMKfmMEeC_eLZALo-S0A")]
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
    /// Identification of a previously sent movement preliminary advice document.
    /// </summary>
    [IsoId("_15PMLfmMEeC_eLZALo-S0A")]
    [DisplayName("Movement Preliminary Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MvmntPrlimryAdvcId")]
    #endif
    [IsoXmlTag("MvmntPrlimryAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification15? MovementPreliminaryAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification15? MovementPreliminaryAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification15? MovementPreliminaryAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a related instruction document.
    /// </summary>
    [IsoId("_15PMMfmMEeC_eLZALo-S0A")]
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
    [IsoId("_15PMNfmMEeC_eLZALo-S0A")]
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
    [IsoId("_15PMOfmMEeC_eLZALo-S0A")]
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
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_15PMPfmMEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionGeneralInformation39 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionGeneralInformation39 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionGeneralInformation39 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionGeneralInformation39 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the safekeeping account, owner and account balance.
    /// </summary>
    [IsoId("_15PMQfmMEeC_eLZALo-S0A")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountAndBalance16 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountAndBalance16 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountAndBalance16 AccountDetails { get; init; } 
    #else
    public AccountAndBalance16 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the corporate action option.
    /// </summary>
    [IsoId("_15PMRfmMEeC_eLZALo-S0A")]
    [DisplayName("Corporate Action Confirmation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnConfDtls")]
    #endif
    [IsoXmlTag("CorpActnConfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption37 CorporateActionConfirmationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption37 CorporateActionConfirmationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption37 CorporateActionConfirmationDetails { get; init; } 
    #else
    public CorporateActionOption37 CorporateActionConfirmationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_15PMSfmMEeC_eLZALo-S0A")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative4? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative4? AdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative4? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party appointed to administer the event on behalf of the issuer company/offeror. The party may be contacted for more information about the event.
    /// </summary>
    [IsoId("_15PMTfmMEeC_eLZALo-S0A")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification46Choice_? IssuerAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification46Choice_? IssuerAgent { get; init; } 
    #else
    public PartyIdentification46Choice_? IssuerAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Agent (principal or fiscal paying agent) appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_15PMUfmMEeC_eLZALo-S0A")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification46Choice_? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification46Choice_? PayingAgent { get; init; } 
    #else
    public PartyIdentification46Choice_? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-agent appointed to execute the payment for the corporate action event on behalf of the issuer company/offeror.
    /// </summary>
    [IsoId("_15PMVfmMEeC_eLZALo-S0A")]
    [DisplayName("Sub Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPngAgt")]
    #endif
    [IsoXmlTag("SubPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification46Choice_? SubPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification46Choice_? SubPayingAgent { get; init; } 
    #else
    public PartyIdentification46Choice_? SubPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_15PMWfmMEeC_eLZALo-S0A")]
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


// Since CorporateActionMovementConfirmationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CorporateActionMovementConfirmationV03.

