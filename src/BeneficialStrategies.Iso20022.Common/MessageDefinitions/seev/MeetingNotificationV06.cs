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
/// This record is an implementation of the seev.001.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.
/// Usage
/// The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(@"Scope|The MeetingNotification message is sent by a notifying party, for example, an issuer, its agent or an intermediary to another intermediary, a party holding the right to vote, a registered security holder or to a beneficial holder to announce a meeting.|Usage|The MeetingNotification message is used to announce a meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|This message definition is intended for use with the Business Application Header.")]
[IsoId("_yXBbk6yREemMosWmlQ33EA")]
[DisplayName("Meeting Notification V")]
public partial record MeetingNotificationV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.001.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.06";
    
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
    /// General information about the event notification type and status.
    /// </summary>
    [IsoId("_U2Q0UK7PEemG7MmivSuE5g")]
    [DisplayName("Notification General Information")]
    [IsoXmlTag("NtfctnGnlInf")]
    public required NotificationGeneralInformation1 NotificationGeneralInformation { get; init; } 
    
    /// <summary>
    /// Information specific to notification amendment as for instance the identification to a previous meeting notification.
    /// </summary>
    [IsoId("_yXBbm6yREemMosWmlQ33EA")]
    [DisplayName("Notification Update")]
    [IsoXmlTag("NtfctnUpd")]
    public NotificationUpdate1? NotificationUpdate { get; init; } 
    
    /// <summary>
    /// Identification of another meeting event that needs to be closely linked to the processing of the event notified in this meeting notification.
    /// </summary>
    [IsoId("_qLxIka7rEemG7MmivSuE5g")]
    [DisplayName("Events Linkage")]
    [IsoXmlTag("EvtsLkg")]
    public MeetingEventReference1? EventsLinkage { get; init; } 
    
    /// <summary>
    /// Specifies information about the meeting like meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_yXBbn6yREemMosWmlQ33EA")]
    [DisplayName("Meeting")]
    [IsoXmlTag("Mtg")]
    public required MeetingNotice5 Meeting { get; init; } 
    
    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_yXBboayREemMosWmlQ33EA")]
    [DisplayName("Meeting Details")]
    [IsoXmlTag("MtgDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<Meeting5> MeetingDetails { get; init; } = [];
    
    /// <summary>
    /// Institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_yXBbo6yREemMosWmlQ33EA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required IssuerInformation3 Issuer { get; init; } 
    
    /// <summary>
    /// Agent of the issuer.
    /// </summary>
    [IsoId("_yXBbpayREemMosWmlQ33EA")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<IssuerAgent3> IssuerAgent { get; init; } = [];
    
    /// <summary>
    /// Financial instrument identification and net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_yXBbp6yREemMosWmlQ33EA")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition10> Security { get; init; } = [];
    
    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_yXBbqayREemMosWmlQ33EA")]
    [DisplayName("Resolution")]
    [IsoXmlTag("Rsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Resolution4> Resolution { get; init; } = [];
    
    /// <summary>
    /// Conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_yXBbq6yREemMosWmlQ33EA")]
    [DisplayName("Vote")]
    [IsoXmlTag("Vote")]
    public VoteParameters5? Vote { get; init; } 
    
    /// <summary>
    /// Information about the use of Power of Attorney.
    /// </summary>
    [IsoId("_yXBbr6yREemMosWmlQ33EA")]
    [DisplayName("Power Of Attorney Requirements")]
    [IsoXmlTag("PwrOfAttnyRqrmnts")]
    public PowerOfAttorneyRequirements4? PowerOfAttorneyRequirements { get; init; } 
    
    /// <summary>
    /// Additional narrative information about the corporate event.
    /// </summary>
    [IsoId("_yXBbsayREemMosWmlQ33EA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateEventNarrative2? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yXBbs6yREemMosWmlQ33EA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MeetingNotificationV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingNotificationV06.

