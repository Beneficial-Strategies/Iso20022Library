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
/// This record is an implementation of the seev.010.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to request the cancellation of a notification advice message.
/// Usage
/// When this message is used to request the cancellation of a notification advice message, the function of the message must be cancellation.
/// When this message is used to request the withdrawal of a Corporate Action event or option, then the function of the message must be withdrawal.
/// In both cases, the building block notification advice identification must be present to link this cancellation request to the notification advice that was previously sent.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to request the cancellation of a notification advice message.|Usage|When this message is used to request the cancellation of a notification advice message, the function of the message must be cancellation.|When this message is used to request the withdrawal of a Corporate Action event or option, then the function of the message must be withdrawal.|In both cases, the building block notification advice identification must be present to link this cancellation request to the notification advice that was previously sent.")]
[IsoId("_TRVISdEwEd-BzquC8wXy7w_1381384285")]
[DisplayName("Agent CA Notification Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCANotificationCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.010.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCANtfctnCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.010.001.01";
    
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
    /// Constructs a AgentCANotificationCancellationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCANotificationCancellationRequestV01( DocumentIdentification8 reqIdentification,NotificationCancellation1 reqNotificationCancellationTypeAndLinkage,CorporateActionInformation2 reqCorporateActionGeneralInformation )
    {
        Identification = reqIdentification;
        NotificationCancellationTypeAndLinkage = reqNotificationCancellationTypeAndLinkage;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TRVIStEwEd-BzquC8wXy7w_-958501125")]
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
    /// Provides information about the type of notification cancellation request and linked message.
    /// </summary>
    [IsoId("_TRVIS9EwEd-BzquC8wXy7w_604000016")]
    [DisplayName("Notification Cancellation Type And Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnCxlTpAndLkg")]
    #endif
    [IsoXmlTag("NtfctnCxlTpAndLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationCancellation1 NotificationCancellationTypeAndLinkage { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationCancellation1 NotificationCancellationTypeAndLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationCancellation1 NotificationCancellationTypeAndLinkage { get; init; } 
    #else
    public NotificationCancellation1 NotificationCancellationTypeAndLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRVITNEwEd-BzquC8wXy7w_-624173928")]
    [DisplayName("Corporate Action General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnGnlInf")]
    #endif
    [IsoXmlTag("CorpActnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionInformation2 CorporateActionGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionInformation2 CorporateActionGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionInformation2 CorporateActionGeneralInformation { get; init; } 
    #else
    public CorporateActionInformation2 CorporateActionGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information of the notification advice to be cancelled.
    /// </summary>
    [IsoId("_TRVITdEwEd-BzquC8wXy7w_807888623")]
    [DisplayName("Corporate Action Notification Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnNtfctnDtls")]
    #endif
    [IsoXmlTag("CorpActnNtfctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNotificationAdvice1? CorporateActionNotificationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNotificationAdvice1? CorporateActionNotificationDetails { get; init; } 
    #else
    public CorporateActionNotificationAdvice1? CorporateActionNotificationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCANotificationCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCANotificationCancellationRequestV01.

