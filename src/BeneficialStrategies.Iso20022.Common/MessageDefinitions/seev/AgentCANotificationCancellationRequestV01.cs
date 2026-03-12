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
    
    #nullable enable
    
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the cancellation request.
    /// </summary>
    [IsoId("_TRVIStEwEd-BzquC8wXy7w_-958501125")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Provides information about the type of notification cancellation request and linked message.
    /// </summary>
    [IsoId("_TRVIS9EwEd-BzquC8wXy7w_604000016")]
    [DisplayName("Notification Cancellation Type And Linkage")]
    [IsoXmlTag("NtfctnCxlTpAndLkg")]
    public required NotificationCancellation1 NotificationCancellationTypeAndLinkage { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRVITNEwEd-BzquC8wXy7w_-624173928")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation2 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Detailed information of the notification advice to be cancelled.
    /// </summary>
    [IsoId("_TRVITdEwEd-BzquC8wXy7w_807888623")]
    [DisplayName("Corporate Action Notification Details")]
    [IsoXmlTag("CorpActnNtfctnDtls")]
    public CorporateActionNotificationAdvice1? CorporateActionNotificationDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCANotificationCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCANotificationCancellationRequestV01.

