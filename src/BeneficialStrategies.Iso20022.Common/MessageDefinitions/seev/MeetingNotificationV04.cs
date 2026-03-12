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
/// This record is an implementation of the seev.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A notifying party, eg, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.
/// Usage
/// The MeetingNotification message is used to announce a shareholders meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.
/// To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.
/// </summary>
[Description(@"Scope|A notifying party, eg, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.|Usage|The MeetingNotification message is used to announce a shareholders meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.|To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.")]
[IsoId("_TsTNC9EwEd-BzquC8wXy7w_1709112715")]
[DisplayName("Meeting Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingNotificationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.001.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.04";
    
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
    /// Constructs a MeetingNotificationV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingNotificationV04( MessageIdentification1 reqIdentification,NotificationStatus1 reqNotificationStatus,MeetingNotice3 reqMeeting,PartyIdentification9Choice_ reqNotifyingParty,IssuerInformation1 reqIssuer,EntitlementAssessment2 reqEntitlementSpecification )
    {
        Identification = reqIdentification;
        NotificationStatus = reqNotificationStatus;
        Meeting = reqMeeting;
        NotifyingParty = reqNotifyingParty;
        Issuer = reqIssuer;
        EntitlementSpecification = reqEntitlementSpecification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the meeting notification message.
    /// </summary>
    [IsoId("_TsTNDNEwEd-BzquC8wXy7w_-2037621454")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 Identification { get; init; } 
    #else
    public MessageIdentification1 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Information specific to an amendment.
    /// </summary>
    [IsoId("_TsTNDdEwEd-BzquC8wXy7w_2083259089")]
    [DisplayName("Amendment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amdmnt")]
    #endif
    [IsoXmlTag("Amdmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmendInformation1? Amendment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmendInformation1? Amendment { get; init; } 
    #else
    public AmendInformation1? Amendment { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the global status of the event contained in the notification.
    /// </summary>
    [IsoId("_TscW8NEwEd-BzquC8wXy7w_-797471585")]
    [DisplayName("Notification Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnSts")]
    #endif
    [IsoXmlTag("NtfctnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationStatus1 NotificationStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationStatus1 NotificationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationStatus1 NotificationStatus { get; init; } 
    #else
    public NotificationStatus1 NotificationStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies information about the meeting. This component contains meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_TscW8dEwEd-BzquC8wXy7w_1033451584")]
    [DisplayName("Meeting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtg")]
    #endif
    [IsoXmlTag("Mtg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingNotice3 Meeting { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingNotice3 Meeting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingNotice3 Meeting { get; init; } 
    #else
    public MeetingNotice3 Meeting { get; set; } 
    #endif
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_TscW8tEwEd-BzquC8wXy7w_1487538853")]
    [DisplayName("Meeting Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgDtls")]
    #endif
    [IsoXmlTag("MtgDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<Meeting3> MeetingDetails { get; init; } = new ValueList<Meeting3>(){};
    
    /// <summary>
    /// Party notifying the meeting.
    /// </summary>
    [IsoId("_TscW89EwEd-BzquC8wXy7w_1476440076")]
    [DisplayName("Notifying Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtifngPty")]
    #endif
    [IsoXmlTag("NtifngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification9Choice_ NotifyingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification9Choice_ NotifyingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification9Choice_ NotifyingParty { get; init; } 
    #else
    public PartyIdentification9Choice_ NotifyingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_TscW9NEwEd-BzquC8wXy7w_-232527808")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IssuerInformation1 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IssuerInformation1 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerInformation1 Issuer { get; init; } 
    #else
    public IssuerInformation1 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Agents of the issuer.
    /// </summary>
    [IsoId("_TscW9dEwEd-BzquC8wXy7w_-1304532867")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<IssuerAgent1> IssuerAgent { get; init; } = new ValueList<IssuerAgent1>(){};
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_TscW9tEwEd-BzquC8wXy7w_-1315631644")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition6> Security { get; init; } = new ValueList<SecurityPosition6>(){};
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_TscW99EwEd-BzquC8wXy7w_-861544375")]
    [DisplayName("Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsltn")]
    #endif
    [IsoXmlTag("Rsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Resolution2> Resolution { get; init; } = new ValueList<Resolution2>(){};
    
    /// <summary>
    /// Specifies the conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_TsmH8NEwEd-BzquC8wXy7w_969378794")]
    [DisplayName("Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vote")]
    #endif
    [IsoXmlTag("Vote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteParameters3? Vote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteParameters3? Vote { get; init; } 
    #else
    public VoteParameters3? Vote { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the entitlement ratio and the different deadlines for calculating the entitlement.
    /// </summary>
    [IsoId("_TsmH8dEwEd-BzquC8wXy7w_-1911351880")]
    [DisplayName("Entitlement Specification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntSpcfctn")]
    #endif
    [IsoXmlTag("EntitlmntSpcfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EntitlementAssessment2 EntitlementSpecification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EntitlementAssessment2 EntitlementSpecification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EntitlementAssessment2 EntitlementSpecification { get; init; } 
    #else
    public EntitlementAssessment2 EntitlementSpecification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies requirements relative to the use of Power of Attorney.
    /// </summary>
    [IsoId("_TsmH8tEwEd-BzquC8wXy7w_-1949337923")]
    [DisplayName("Power Of Attorney Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttnyRqrmnts")]
    #endif
    [IsoXmlTag("PwrOfAttnyRqrmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PowerOfAttorneyRequirements2? PowerOfAttorneyRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PowerOfAttorneyRequirements2? PowerOfAttorneyRequirements { get; init; } 
    #else
    public PowerOfAttorneyRequirements2? PowerOfAttorneyRequirements { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional narrative information about the corporate event.
    /// </summary>
    [IsoId("_TsmH89EwEd-BzquC8wXy7w_-870758796")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateEventNarrative2? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateEventNarrative2? AdditionalInformation { get; init; } 
    #else
    public CorporateEventNarrative2? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_TsmH9NEwEd-BzquC8wXy7w_1561886891")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension2? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension2? Extension { get; init; } 
    #else
    public Extension2? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingNotificationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingNotificationV04.

