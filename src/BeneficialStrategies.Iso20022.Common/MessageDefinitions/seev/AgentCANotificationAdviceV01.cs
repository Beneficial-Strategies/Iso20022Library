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
/// This record is an implementation of the seev.009.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by an issuer (or its agent) to a CSD to:
/// - Provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD; and
/// - to update a corporate action notification. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information.
/// Usage
/// This message is used:
/// - to provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD. The information can be complete or incomplete.
/// - to update a corporate action notification advice. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information. As per SMPG recommendation, all the information should be provided in the update, not only updated information.
/// An Agent Corporate Action Notification Status Advice is sent in reply to the Agent Corporate Action Notification Advice.
/// Note: The amendment of a corporate action notification is done through a replacement mechanism in line with both the ISO 15022 messages used in the flow between the CSD and its clients, and the ISO 20022 proxy voting messages.
/// </summary>
[Description(@"Scope|This message is sent by an issuer (or its agent) to a CSD to:|- Provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD; and|- to update a corporate action notification. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information.|Usage|This message is used:|- to provide a CSD with the details of a corporate action along with the possible options available to the clients of that CSD. The information can be complete or incomplete.|- to update a corporate action notification advice. A notification advice can be initially sent as a preliminary advice and subsequently replaced by another notification advice with updated information. As per SMPG recommendation, all the information should be provided in the update, not only updated information.|An Agent Corporate Action Notification Status Advice is sent in reply to the Agent Corporate Action Notification Advice.|Note: The amendment of a corporate action notification is done through a replacement mechanism in line with both the ISO 15022 messages used in the flow between the CSD and its clients, and the ISO 20022 proxy voting messages.")]
[IsoId("_TRBmS9EwEd-BzquC8wXy7w_-1004018302")]
[DisplayName("Agent CA Notification Advice V")]
public partial record AgentCANotificationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.009.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCANtfctnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.009.001.01";
    
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
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TRBmTNEwEd-BzquC8wXy7w_-1254952623")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; } 
    
    /// <summary>
    /// Provides information about the type of notification advice and linked message.
    /// </summary>
    [IsoId("_TRBmTdEwEd-BzquC8wXy7w_1228461264")]
    [DisplayName("Notification Type And Linkage")]
    [IsoXmlTag("NtfctnTpAndLkg")]
    public required LinkedCorporateAction1 NotificationTypeAndLinkage { get; init; } 
    
    /// <summary>
    /// Provides general information about the notification advice.
    /// </summary>
    [IsoId("_TRLXQNEwEd-BzquC8wXy7w_2096170446")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public required CorporateActionNotification1 NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRLXQdEwEd-BzquC8wXy7w_1097129069")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation2 CorporateActionGeneralInformation { get; init; } 
    
    /// <summary>
    /// Provides details information about the CA event.
    /// </summary>
    [IsoId("_TRLXQtEwEd-BzquC8wXy7w_314771575")]
    [DisplayName("Corporate Action Details")]
    [IsoXmlTag("CorpActnDtls")]
    public required CorporateAction2 CorporateActionDetails { get; init; } 
    
    /// <summary>
    /// Provides detailed information about the option of the CA event.
    /// </summary>
    [IsoId("_TRLXQ9EwEd-BzquC8wXy7w_-153062975")]
    [DisplayName("Corporate Action Option Details")]
    [IsoXmlTag("CorpActnOptnDtls")]
    public CorporateActionOption1? CorporateActionOptionDetails { get; init; } 
    
    /// <summary>
    /// Provides information about the contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TRLXRNEwEd-BzquC8wXy7w_1561246672")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    public ContactPerson1? ContactDetails { get; init; } 
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TRLXRdEwEd-BzquC8wXy7w_335889321")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative2? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}


// Since AgentCANotificationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCANotificationAdviceV01.

