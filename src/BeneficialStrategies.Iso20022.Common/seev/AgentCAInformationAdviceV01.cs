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
/// This record is an implementation of the seev.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to provide information about the certification and/or the delivery details to the issuer (or its agent).
/// Usage
/// This message can be used in the case of a corporate action event without an election.
/// This message can also be used in the case of a corporate action event with election when the election details and the additional information cannot be provided in the same message. In this case, the Agent Corporate Action Election Advice Identification must be used to link this message to the election advice for which additional information is provided.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to provide information about the certification and/or the delivery details to the issuer (or its agent).|Usage|This message can be used in the case of a corporate action event without an election.|This message can also be used in the case of a corporate action event with election when the election details and the additional information cannot be provided in the same message. In this case, the Agent Corporate Action Election Advice Identification must be used to link this message to the election advice for which additional information is provided.")]
[IsoId("_TODKy9EwEd-BzquC8wXy7w_-190409931")]
[DisplayName("Agent CA Information Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAInformationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.023.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAInfAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.023.001.01";
    
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
    /// Constructs a AgentCAInformationAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAInformationAdviceV01( DocumentIdentification8 reqIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,SecuritiesAccount7 reqAccountDetails,CorporateActionAdditionalInformation1 reqCorporateActionAdditionalInformation )
    {
        Identification = reqIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        AccountDetails = reqAccountDetails;
        CorporateActionAdditionalInformation = reqCorporateActionAdditionalInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TODKzNEwEd-BzquC8wXy7w_1736726928")]
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
    /// Identification of the linked Agent CA Election Advice Identification.
    /// </summary>
    [IsoId("_TODKzdEwEd-BzquC8wXy7w_1770899654")]
    [DisplayName("Agent CA Election Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAElctnAdvcId")]
    #endif
    [IsoXmlTag("AgtCAElctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8? AgentCAElectionAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TODKztEwEd-BzquC8wXy7w_582576991")]
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
    /// Information about the account for which additional information is provided.
    /// </summary>
    [IsoId("_TODKz9EwEd-BzquC8wXy7w_-559361420")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount7 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount7 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount7 AccountDetails { get; init; } 
    #else
    public SecuritiesAccount7 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the corporate action such as the delivery details.
    /// </summary>
    [IsoId("_TOM7wNEwEd-BzquC8wXy7w_196544282")]
    [DisplayName("Corporate Action Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnAddtlInf")]
    #endif
    [IsoXmlTag("CorpActnAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionAdditionalInformation1 CorporateActionAdditionalInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionAdditionalInformation1 CorporateActionAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionAdditionalInformation1 CorporateActionAdditionalInformation { get; init; } 
    #else
    public CorporateActionAdditionalInformation1 CorporateActionAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TOM7wdEwEd-BzquC8wXy7w_485761108")]
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


// Since AgentCAInformationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAInformationAdviceV01.

