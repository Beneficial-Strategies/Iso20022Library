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
/// This record is an implementation of the seev.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to report the status, or change in status, of a notification advice or notification cancellation request.
/// Usage
/// When this message is used to report the status of a notification advice then the building block Agent Corporate Action Notification Advice Identification must be present.
/// When this message is used to provide the status of a notification cancellation request then the building block Notification Cancellation Request Identification must be present.
/// </summary>
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to report the status, or change in status, of a notification advice or notification cancellation request.|Usage|When this message is used to report the status of a notification advice then the building block Agent Corporate Action Notification Advice Identification must be present.|When this message is used to provide the status of a notification cancellation request then the building block Notification Cancellation Request Identification must be present.")]
[IsoId("_TReSOdEwEd-BzquC8wXy7w_-1525445298")]
[DisplayName("Agent CA Notification Status Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgentCANotificationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCANtfctnStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.011.001.01";
    
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
    /// Constructs a AgentCANotificationStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgentCANotificationStatusAdviceV01( DocumentIdentification8 reqIdentification,DocumentIdentification8 reqAgentCANotificationAdviceIdentification,DocumentIdentification8 reqAgentCANotificationCancellationRequestIdentification,CorporateActionInformation2 reqCorporateActionGeneralInformation,NotificationCancellationRequestStatus1Choice_ reqNotificationCancellationRequestStatus,NotificationAdviceStatus1Choice_ reqNotificationAdviceStatus )
    {
        Identification = reqIdentification;
        AgentCANotificationAdviceIdentification = reqAgentCANotificationAdviceIdentification;
        AgentCANotificationCancellationRequestIdentification = reqAgentCANotificationCancellationRequestIdentification;
        CorporateActionGeneralInformation = reqCorporateActionGeneralInformation;
        NotificationCancellationRequestStatus = reqNotificationCancellationRequestStatus;
        NotificationAdviceStatus = reqNotificationAdviceStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TReSOtEwEd-BzquC8wXy7w_-885544808")]
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
    /// Identification of the linked Agent CA Notification Advice for which a status is given.
    /// </summary>
    [IsoId("_TReSO9EwEd-BzquC8wXy7w_-867070991")]
    [DisplayName("Agent CA Notification Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCANtfctnAdvcId")]
    #endif
    [IsoXmlTag("AgtCANtfctnAdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCANotificationAdviceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCANotificationAdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCANotificationAdviceIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCANotificationAdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the linked Agent CA Notification Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TReSPNEwEd-BzquC8wXy7w_-853220988")]
    [DisplayName("Agent CA Notification Cancellation Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtCANtfctnCxlReqId")]
    #endif
    [IsoXmlTag("AgtCANtfctnCxlReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification8 AgentCANotificationCancellationRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification8 AgentCANotificationCancellationRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification8 AgentCANotificationCancellationRequestIdentification { get; init; } 
    #else
    public DocumentIdentification8 AgentCANotificationCancellationRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRoDMNEwEd-BzquC8wXy7w_-1070148838")]
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
    /// Status of the Notification Cancellation Request sent by the issuer (agent).
    /// </summary>
    [IsoId("_TRoDMdEwEd-BzquC8wXy7w_-979644850")]
    [DisplayName("Notification Cancellation Request Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnCxlReqSts")]
    #endif
    [IsoXmlTag("NtfctnCxlReqSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationCancellationRequestStatus1Choice_ NotificationCancellationRequestStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationCancellationRequestStatus1Choice_ NotificationCancellationRequestStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationCancellationRequestStatus1Choice_ NotificationCancellationRequestStatus { get; init; } 
    #else
    public NotificationCancellationRequestStatus1Choice_ NotificationCancellationRequestStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the notification advice sent by the issuer (agent).
    /// </summary>
    [IsoId("_TRoDMtEwEd-BzquC8wXy7w_-982413026")]
    [DisplayName("Notification Advice Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnAdvcSts")]
    #endif
    [IsoXmlTag("NtfctnAdvcSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationAdviceStatus1Choice_ NotificationAdviceStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationAdviceStatus1Choice_ NotificationAdviceStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationAdviceStatus1Choice_ NotificationAdviceStatus { get; init; } 
    #else
    public NotificationAdviceStatus1Choice_ NotificationAdviceStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AgentCANotificationStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCANotificationStatusAdviceV01.

