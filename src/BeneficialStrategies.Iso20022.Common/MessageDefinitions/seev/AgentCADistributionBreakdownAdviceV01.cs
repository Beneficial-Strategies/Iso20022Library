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
/// This record is an implementation of the seev.016.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to provide distribution breakdown information for the proceeds that are to be delivered outside the CSD (e.g. when the proceeds are not eligible in the CSD).
/// Usage
/// This message is used to provide distribution breakdown information (securities and/or cash) per account for a specific corporate action option.
/// Note: the delivery details are sent through the Agent Corporate Action Information Advice.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to provide distribution breakdown information for the proceeds that are to be delivered outside the CSD (e.g. when the proceeds are not eligible in the CSD).|Usage|This message is used to provide distribution breakdown information (securities and/or cash) per account for a specific corporate action option.|Note: the delivery details are sent through the Agent Corporate Action Information Advice.")]
[IsoId("_TMj9DtEwEd-BzquC8wXy7w_707588589")]
[DisplayName("Agent CA Distribution Breakdown Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCADistributionBreakdownAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.016.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCADstrbtnBrkdwnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.016.001.01";
    
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
    /// Constructs a AgentCADistributionBreakdownAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCADistributionBreakdownAdviceV01( DocumentIdentification8 reqIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,EntitlementAdvice1 reqCorporateActionDistributionDetails )
    {
        Identification = reqIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        CorporateActionDistributionDetails = reqCorporateActionDistributionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TMj9D9EwEd-BzquC8wXy7w_-123045337")]
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
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TMj9ENEwEd-BzquC8wXy7w_1139796912")]
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
    /// Provides information about the CA option and the entitlements.
    /// </summary>
    [IsoId("_TMtG8NEwEd-BzquC8wXy7w_1455640472")]
    [DisplayName("Corporate Action Distribution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnDstrbtnDtls")]
    #endif
    [IsoXmlTag("CorpActnDstrbtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EntitlementAdvice1 CorporateActionDistributionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EntitlementAdvice1 CorporateActionDistributionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntitlementAdvice1 CorporateActionDistributionDetails { get; init; } 
    #else
    public EntitlementAdvice1 CorporateActionDistributionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCADistributionBreakdownAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCADistributionBreakdownAdviceV01.

