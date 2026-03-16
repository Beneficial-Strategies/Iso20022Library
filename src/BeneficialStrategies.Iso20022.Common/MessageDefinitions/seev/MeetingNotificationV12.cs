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
/// This record is an implementation of the seev.001.001.12 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_UbvIYX_5Ee-h086v0qPiyQ")]
[DisplayName("Meeting Notification V12")]
public partial record MeetingNotificationV12 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.001.001.12";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.12";
    
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
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateEventNarrative4? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Events Linkage.
    /// </summary>
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public ValueList<MeetingEventReference1> EventsLinkage { get; init; } = [];
    
    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required IssuerInformation3 Issuer { get; init; } 
    
    /// <summary>
    /// Issuer Agent.
    /// </summary>
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    public IssuerAgent3? IssuerAgent { get; init; } 
    
    /// <summary>
    /// Meeting.
    /// </summary>
    [DisplayName("Meeting")]
    [IsoXmlTag("Mtg")]
    public required MeetingNotice9 Meeting { get; init; } 
    
    /// <summary>
    /// Meeting Details.
    /// </summary>
    [DisplayName("Meeting Details")]
    [IsoXmlTag("MtgDtls")]
    public required Meeting7 MeetingDetails { get; init; } 
    
    /// <summary>
    /// Notification General Information.
    /// </summary>
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public required NotificationGeneralInformation4 NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// Notification Update.
    /// </summary>
    [DisplayName("Notification Update")]
    [IsoXmlTag("NtfctnUpd")]
    public NotificationUpdate2? NotificationUpdate { get; init; } 
    
    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public Pagination1? Pagination { get; init; } 
    
    /// <summary>
    /// Power Of Attorney Requirements.
    /// </summary>
    [DisplayName("Power Of Attorney Requirements")]
    [IsoXmlTag("PwrOfAttnyRqrmnts")]
    public PowerOfAttorneyRequirements4? PowerOfAttorneyRequirements { get; init; } 
    
    /// <summary>
    /// Resolution.
    /// </summary>
    [DisplayName("Resolution")]
    [IsoXmlTag("Rsltn")]
    public Resolution8? Resolution { get; init; } 
    
    /// <summary>
    /// Security.
    /// </summary>
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public required SecurityPosition20 Security { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    /// <summary>
    /// Vote.
    /// </summary>
    [DisplayName("Vote")]
    [IsoXmlTag("Vote")]
    public VoteParameters9? Vote { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingNotificationV12Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingNotificationV12.

