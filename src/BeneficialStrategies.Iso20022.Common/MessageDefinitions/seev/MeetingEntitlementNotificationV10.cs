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
/// This record is an implementation of the seev.003.001.10 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_UbvIn3_5Ee-h086v0qPiyQ")]
[DisplayName("Meeting Entitlement Notification V10")]
public partial record MeetingEntitlementNotificationV10 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.003.001.10";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.10";
    
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
    /// Eligibility.
    /// </summary>
    [DisplayName("Eligibility")]
    [IsoXmlTag("Elgblty")]
    public required EligibilityDates1 Eligibility { get; init; } 
    
    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required PartyIdentification129Choice_ Issuer { get; init; } 
    
    /// <summary>
    /// Meeting Attendee.
    /// </summary>
    [DisplayName("Meeting Attendee")]
    [IsoXmlTag("MtgAttndee")]
    public PartyIdentification232Choice_? MeetingAttendee { get; init; } 
    
    /// <summary>
    /// Meeting Reference.
    /// </summary>
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; } 
    
    /// <summary>
    /// Notification Type.
    /// </summary>
    [DisplayName("Notification Type")]
    [IsoXmlTag("NtfctnTp")]
    public required NotificationType2Code NotificationType { get; init; } 
    
    /// <summary>
    /// Previous Entitlement Notification Identification.
    /// </summary>
    [DisplayName("Previous Entitlement Notification Identification")]
    [IsoXmlTag("PrvsEntitlmntNtfctnId")]
    public IsoMax35Text? PreviousEntitlementNotificationIdentification { get; init; } 
    
    /// <summary>
    /// Proxy.
    /// </summary>
    [DisplayName("Proxy")]
    [IsoXmlTag("Prxy")]
    public PartyIdentification232Choice_? Proxy { get; init; } 
    
    /// <summary>
    /// Security.
    /// </summary>
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public required SecurityPosition21 Security { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    
    #nullable disable
    
}


// Since MeetingEntitlementNotificationV10Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingEntitlementNotificationV10.

