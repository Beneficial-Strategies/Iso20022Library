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
/// This record is an implementation of the seev.003.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the MeetingEntitlementNotification to an issuer, its agent, an intermediary or an account owner to advise the entitlement in relation to a shareholders meeting.
/// Usage
/// This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place.
/// This entitlement message is sent by the account servicer or the registrar to an intermediary, the issuer&apos;s agent or the issuer. It is also sent between the account servicer and the account owner or the party holding the right to vote.
/// The message is also used to amend a previously sent MeetingEntitlementNotification. To notify an update, the RelatedReference must be included in the message.
/// </summary>
[Description(@"Scope|An account servicer sends the MeetingEntitlementNotification to an issuer, its agent, an intermediary or an account owner to advise the entitlement in relation to a shareholders meeting.|Usage|This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place.|This entitlement message is sent by the account servicer or the registrar to an intermediary, the issuer's agent or the issuer. It is also sent between the account servicer and the account owner or the party holding the right to vote.|The message is also used to amend a previously sent MeetingEntitlementNotification. To notify an update, the RelatedReference must be included in the message.")]
[IsoId("_TmC0DdEwEd-BzquC8wXy7w_-554853973")]
[DisplayName("Meeting Entitlement Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MeetingEntitlementNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.003.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.02";
    
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
    /// Constructs a MeetingEntitlementNotificationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MeetingEntitlementNotificationV02( MessageIdentification1 reqEntitlementNotificationIdentification,MeetingReference3 reqMeetingReference,PartyIdentification9Choice_ reqNotifyingParty,EligibilityDates1 reqEligibility )
    {
        EntitlementNotificationIdentification = reqEntitlementNotificationIdentification;
        MeetingReference = reqMeetingReference;
        NotifyingParty = reqNotifyingParty;
        Eligibility = reqEligibility;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the notification of entitlement instruction.
    /// </summary>
    [IsoId("_TmL98NEwEd-BzquC8wXy7w_-554853971")]
    [DisplayName("Entitlement Notification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntNtfctnId")]
    #endif
    [IsoXmlTag("EntitlmntNtfctnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 EntitlementNotificationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 EntitlementNotificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 EntitlementNotificationIdentification { get; init; } 
    #else
    public MessageIdentification1 EntitlementNotificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the meeting entitlement message to be modified.
    /// </summary>
    [IsoId("_TmL98dEwEd-BzquC8wXy7w_-554853690")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification? RelatedReference { get; init; } 
    #else
    public MessageIdentification? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TmL98tEwEd-BzquC8wXy7w_-554853955")]
    [DisplayName("Meeting Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtgRef")]
    #endif
    [IsoXmlTag("MtgRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MeetingReference3 MeetingReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MeetingReference3 MeetingReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MeetingReference3 MeetingReference { get; init; } 
    #else
    public MeetingReference3 MeetingReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party notifying the entitlement.
    /// </summary>
    [IsoId("_TmL989EwEd-BzquC8wXy7w_-554853937")]
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
    /// Identifies the security for which the meeting is organised, the account and the positions of the security holder.
    /// </summary>
    [IsoId("_TmL99NEwEd-BzquC8wXy7w_-554853942")]
    [DisplayName("Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scty")]
    #endif
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition5> Security { get; init; } = new ValueList<SecurityPosition5>(){};
    
    /// <summary>
    /// Defines the dates determining eligibility.
    /// </summary>
    [IsoId("_TmL99dEwEd-BzquC8wXy7w_-554853695")]
    [DisplayName("Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Elgblty")]
    #endif
    [IsoXmlTag("Elgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EligibilityDates1 Eligibility { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EligibilityDates1 Eligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EligibilityDates1 Eligibility { get; init; } 
    #else
    public EligibilityDates1 Eligibility { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since MeetingEntitlementNotificationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingEntitlementNotificationV02.

