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
/// This record is an implementation of the seev.001.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.
/// Usage
/// The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope|The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.|Usage|The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_nIzHwTQ7Ee22Z83HpR5E8w")]
[DisplayName("Meeting Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingNotificationV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.001.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.10";
    
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
    /// Constructs a MeetingNotificationV10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingNotificationV10( NotificationGeneralInformation4 reqNotificationGeneralInformation,MeetingNotice8 reqMeeting,IssuerInformation3 reqIssuer )
    {
        NotificationGeneralInformation = reqNotificationGeneralInformation;
        Meeting = reqMeeting;
        Issuer = reqIssuer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part notification is to continue or that the message is the last page of the multi-part notification.
    /// </summary>
    [IsoId("_nIzH0TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination1? Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1? Pagination { get; init; } 
    #else
    public Pagination1? Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information about the event notification type and status.
    /// </summary>
    [IsoId("_nIzH0zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Notification General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnGnlInf")]
    #endif
    [IsoXmlTag("NtfctnGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NotificationGeneralInformation4 NotificationGeneralInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NotificationGeneralInformation4 NotificationGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationGeneralInformation4 NotificationGeneralInformation { get; init; } 
    #else
    public NotificationGeneralInformation4 NotificationGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information specific to notification amendment as for instance the identification to a previous meeting notification.
    /// </summary>
    [IsoId("_nIzH1TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Notification Update")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtfctnUpd")]
    #endif
    [IsoXmlTag("NtfctnUpd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotificationUpdate2? NotificationUpdate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotificationUpdate2? NotificationUpdate { get; init; } 
    #else
    public NotificationUpdate2? NotificationUpdate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of another meeting event that needs to be closely linked to the processing of the event notified in this meeting notification.
    /// </summary>
    [IsoId("_nIzH1zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Events Linkage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtsLkg")]
    #endif
    [IsoXmlTag("EvtsLkg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MeetingEventReference1? EventsLinkage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingEventReference1? EventsLinkage { get; init; } 
    #else
    public MeetingEventReference1? EventsLinkage { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the meeting like meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_nIzH2TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtg")]
    #endif
    [IsoXmlTag("Mtg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingNotice8 Meeting { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingNotice8 Meeting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingNotice8 Meeting { get; init; } 
    #else
    public MeetingNotice8 Meeting { get; set; } 
    #endif
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_nIzH2zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgDtls")]
    #endif
    [IsoXmlTag("MtgDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<Meeting6> MeetingDetails { get; init; } = new ValueList<Meeting6>(){};
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_nIzH3TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IssuerInformation3 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IssuerInformation3 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerInformation3 Issuer { get; init; } 
    #else
    public IssuerInformation3 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Agent of the issuer.
    /// </summary>
    [IsoId("_nIzH3zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Issuer Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAgt")]
    #endif
    [IsoXmlTag("IssrAgt")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<IssuerAgent3> IssuerAgent { get; init; } = new ValueList<IssuerAgent3>(){};
    
    /// <summary>
    /// Financial instrument identification and net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_nIzH4TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition16> Security { get; init; } = new ValueList<SecurityPosition16>(){};
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_nIzH4zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Resolution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsltn")]
    #endif
    [IsoXmlTag("Rsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Resolution6> Resolution { get; init; } = new ValueList<Resolution6>(){};
    
    /// <summary>
    /// Conditions for voting, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_nIzH5TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Vote")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vote")]
    #endif
    [IsoXmlTag("Vote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VoteParameters8? Vote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteParameters8? Vote { get; init; } 
    #else
    public VoteParameters8? Vote { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the use of power of attorney.
    /// </summary>
    [IsoId("_nIzH5zQ7Ee22Z83HpR5E8w")]
    [DisplayName("Power Of Attorney Requirements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttnyRqrmnts")]
    #endif
    [IsoXmlTag("PwrOfAttnyRqrmnts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PowerOfAttorneyRequirements4? PowerOfAttorneyRequirements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PowerOfAttorneyRequirements4? PowerOfAttorneyRequirements { get; init; } 
    #else
    public PowerOfAttorneyRequirements4? PowerOfAttorneyRequirements { get; set; } 
    #endif
    
    /// <summary>
    /// Additional narrative information about the meeting event.
    /// </summary>
    [IsoId("_nIzH6TQ7Ee22Z83HpR5E8w")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateEventNarrative4? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateEventNarrative4? AdditionalInformation { get; init; } 
    #else
    public CorporateEventNarrative4? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzH6zQ7Ee22Z83HpR5E8w")]
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


// Since MeetingNotificationV10Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingNotificationV10.

