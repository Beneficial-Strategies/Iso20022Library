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
/// This record is an implementation of the seev.012.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to provide information about the clients&apos; election instruction, the registration details, the delivery details, etc. In case of an election with underlying resource movements, it also confirms that these have been completed. This message may also be sent in case of an amendment of an election, once the CSD has completed the required resource movements.
/// Usage
/// This message can be used for a new election advice or an amended election advice.
/// If this message is used for a new election advice, the function of the message must be &apos;new election&apos;.
/// If this message is used for an amended election advice, the function of the message must be &apos;option change&apos; and the identification of the previously sent election advice must be present.
/// This message can include the cash movements and/or securities movements in the case of an election with underlying resource movements. Additionally, this message can include delivery, certification and beneficial owner details.
/// Note: this information can be also sent separately in the Agent Corporate Action Information advice message.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to the issuer (or its agent) to provide information about the clients' election instruction, the registration details, the delivery details, etc. In case of an election with underlying resource movements, it also confirms that these have been completed. This message may also be sent in case of an amendment of an election, once the CSD has completed the required resource movements.|Usage|This message can be used for a new election advice or an amended election advice.|If this message is used for a new election advice, the function of the message must be 'new election'.|If this message is used for an amended election advice, the function of the message must be 'option change' and the identification of the previously sent election advice must be present.|This message can include the cash movements and/or securities movements in the case of an election with underlying resource movements. Additionally, this message can include delivery, certification and beneficial owner details.|Note: this information can be also sent separately in the Agent Corporate Action Information advice message.")]
[IsoId("_TMtG-tEwEd-BzquC8wXy7w_1166385439")]
[DisplayName("Agent CA Election Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAElectionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.012.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.012.001.01";
    
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
    /// Constructs a AgentCAElectionAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAElectionAdviceV01( DocumentIdentification8 reqIdentification,ElectionAdviceFunction1 reqElectionAdviceTypeAndLinkage,CorporateActionInformation1 reqCorporateActionGeneralInformation,CorporateActionElection3 reqElectionDetails )
    {
        Identification = reqIdentification;
        ElectionAdviceTypeAndLinkage = reqElectionAdviceTypeAndLinkage;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        ElectionDetails = reqElectionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TMtG-9EwEd-BzquC8wXy7w_-42698000")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 Identification { get; init; } 
    #else
    public DocumentIdentification8 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the type of election advice and linked messages.
    /// </summary>
    [IsoId("_TM238NEwEd-BzquC8wXy7w_-1990867488")]
    [DisplayName("Election Advice Type And Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnAdvcTpAndLkg")]
    #endif
    [IsoXmlTag("ElctnAdvcTpAndLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ElectionAdviceFunction1 ElectionAdviceTypeAndLinkage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ElectionAdviceFunction1 ElectionAdviceTypeAndLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionAdviceFunction1 ElectionAdviceTypeAndLinkage { get; init; } 
    #else
    public ElectionAdviceFunction1 ElectionAdviceTypeAndLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TM238dEwEd-BzquC8wXy7w_1272192692")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionInformation1 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the election(s).
    /// </summary>
    [IsoId("_TM238tEwEd-BzquC8wXy7w_-1547276927")]
    [DisplayName("Election Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnDtls")]
    #endif
    [IsoXmlTag("ElctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionElection3 ElectionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionElection3 ElectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionElection3 ElectionDetails { get; init; } 
    #else
    public CorporateActionElection3 ElectionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the delivery details, beneficial owner details, etc.
    /// </summary>
    [IsoId("_TM2389EwEd-BzquC8wXy7w_-1731981881")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionAdditionalInformation1? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAdditionalInformation1? AdditionalInformation { get; init; } 
    #else
    public CorporateActionAdditionalInformation1? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TM239NEwEd-BzquC8wXy7w_-741674043")]
    [DisplayName("Contact Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctDtls")]
    #endif
    [IsoXmlTag("CtctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactPerson1? ContactDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactPerson1? ContactDetails { get; init; } 
    #else
    public ContactPerson1? ContactDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAElectionAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAElectionAdviceV01.

