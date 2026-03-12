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
/// This record is an implementation of the seev.003.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingEntitlementNotification is sent by an account servicer to the account owner to advise the entitlement in relation to a meeting.
/// Usage
/// This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place. The message is also used to amend a previously sent MeetingEntitlementNotification. 
/// The MeetingEntitlementNotification message may be sent either before receiving a voting instruction to confirm the entitlement; or after having received a voting instruction to confirm details of the person attending the meeting. 
/// The message may also be used in place of an attendance card or to confirm entitlements in the case of bearer shares.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(@"Scope|The MeetingEntitlementNotification is sent by an account servicer to the account owner to advise the entitlement in relation to a meeting.|Usage|This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place. The message is also used to amend a previously sent MeetingEntitlementNotification. |The MeetingEntitlementNotification message may be sent either before receiving a voting instruction to confirm the entitlement; or after having received a voting instruction to confirm details of the person attending the meeting. |The message may also be used in place of an attendance card or to confirm entitlements in the case of bearer shares.|This message definition is intended for use with the Business Application Header (BAH).")]
[IsoId("_nIzHYTQ7Ee22Z83HpR5E8w")]
[DisplayName("Meeting Entitlement Notification V")]
public partial record MeetingEntitlementNotificationV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.003.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.09";
    
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
    /// Type of notification.
    /// </summary>
    [IsoId("_nIzHazQ7Ee22Z83HpR5E8w")]
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType2Code NotificationType { get; init; } 
    
    /// <summary>
    /// Identification of the original meeting notification entitlement message which is amended.
    /// </summary>
    [IsoId("_nIzHczQ7Ee22Z83HpR5E8w")]
    [DisplayName("Previous Entitlement Notification Identification")]
    [IsoXmlTag("PrvsEntitlmntNtfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PreviousEntitlementNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIzHdTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; } 
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_nIzHdzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification129Choice_ Issuer { get; init; } 
    
    /// <summary>
    /// Security for which the meeting is organised, the account and the positions of the security holder.
    /// </summary>
    [IsoId("_nIzHeTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition18> Security { get; init; } = new ValueList<SecurityPosition18>(){};
    
    /// <summary>
    /// Date determining eligibility.
    /// </summary>
    [IsoId("_nIzHezQ7Ee22Z83HpR5E8w")]
    [DisplayName("Eligibility")]
    [IsoXmlTag("Elgblty")]
    public required EligibilityDates1 Eligibility { get; init; } 
    
    /// <summary>
    /// Person physically attending the meeting as a natural or legal person.
    /// </summary>
    [IsoId("_nIzHfTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public PartyIdentification232Choice_? MeetingAttendee { get; init; } 
    
    /// <summary>
    /// Third party agent assigned by the shareholder that is legally authorised to cast a vote on the shareholder&apos;s behalf at the general meeting.
    /// </summary>
    [IsoId("_nIzHfzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public PartyIdentification232Choice_? Proxy { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIzHgTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingEntitlementNotificationV09Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingEntitlementNotificationV09.

