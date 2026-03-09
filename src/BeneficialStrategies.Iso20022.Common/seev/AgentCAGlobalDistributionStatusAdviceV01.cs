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
/// This record is an implementation of the seev.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to the CSD to authorise/prohibit the CSD to process the entitlement movements.
/// Usage
/// This message is used to authorise/prohibit the CSD to process the movements requested in the Global Distribution Authorisation Request message.
/// Once the amendment request has been accepted by the issuer (or its agent), the CSD will process any resource movement and send an Agent Corporate Action Election Advice message with the function, option change, to confirm that the amendment has been booked at the CSD.
/// The issuer (or its agent) can provide the status in 2 different ways:
/// - Provide a global status, in which case the building block Global Movement Status must be present; or
/// - Provide a status by individual movements, in which case, the building block Individual Movement Status must be present. An individual movement cannot be rejected.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to the CSD to authorise/prohibit the CSD to process the entitlement movements.|Usage|This message is used to authorise/prohibit the CSD to process the movements requested in the Global Distribution Authorisation Request message.|Once the amendment request has been accepted by the issuer (or its agent), the CSD will process any resource movement and send an Agent Corporate Action Election Advice message with the function, option change, to confirm that the amendment has been booked at the CSD.|The issuer (or its agent) can provide the status in 2 different ways:|- Provide a global status, in which case the building block Global Movement Status must be present; or|- Provide a status by individual movements, in which case, the building block Individual Movement Status must be present. An individual movement cannot be rejected.")]
[IsoId("_TN5ZxdEwEd-BzquC8wXy7w_893376547")]
[DisplayName("Agent CA Global Distribution Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCAGlobalDistributionStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAGblDstrbtnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.018.001.01";
    
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
    /// Constructs a AgentCAGlobalDistributionStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCAGlobalDistributionStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCAGlobalDistributionAuthorisationRequestIdentification,CorporateActionInformation1 reqCorporateActionGeneralInformation,GlobalDistributionStatus1 reqGlobalMovementStatus,IndividualMovementStatus1 reqIndividualMovementStatus )
    {
        Identification = reqIdentification;
        AgentCAGlobalDistributionAuthorisationRequestIdentification = reqAgentCAGlobalDistributionAuthorisationRequestIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        GlobalMovementStatus = reqGlobalMovementStatus;
        IndividualMovementStatus = reqIndividualMovementStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TN5ZxtEwEd-BzquC8wXy7w_1263163020")]
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
    /// Identification of the linked Agent CA Global Distribution Authorisation Request for which a status is given.
    /// </summary>
    [IsoId("_TN5Zx9EwEd-BzquC8wXy7w_1294561939")]
    [DisplayName("Agent CA Global Distribution Authorisation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCAGblDstrbtnAuthstnReqId")]
    #endif
    [IsoXmlTag("AgtCAGblDstrbtnAuthstnReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCAGlobalDistributionAuthorisationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCAGlobalDistributionAuthorisationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCAGlobalDistributionAuthorisationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCAGlobalDistributionAuthorisationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TN5ZyNEwEd-BzquC8wXy7w_1839061522")]
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
    /// Provides information about the status of the global movement.
    /// </summary>
    [IsoId("_TN5ZydEwEd-BzquC8wXy7w_-2081880842")]
    [DisplayName("Global Movement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GblMvmntSts")]
    #endif
    [IsoXmlTag("GblMvmntSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GlobalDistributionStatus1 GlobalMovementStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GlobalDistributionStatus1 GlobalMovementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GlobalDistributionStatus1 GlobalMovementStatus { get; init; } 
    #else
    public GlobalDistributionStatus1 GlobalMovementStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the status of an individual movement.
    /// </summary>
    [IsoId("_TN5ZytEwEd-BzquC8wXy7w_-1885018018")]
    [DisplayName("Individual Movement Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IndvMvmntSts")]
    #endif
    [IsoXmlTag("IndvMvmntSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IndividualMovementStatus1 IndividualMovementStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IndividualMovementStatus1 IndividualMovementStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualMovementStatus1 IndividualMovementStatus { get; init; } 
    #else
    public IndividualMovementStatus1 IndividualMovementStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCAGlobalDistributionStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCAGlobalDistributionStatusAdviceV01.

