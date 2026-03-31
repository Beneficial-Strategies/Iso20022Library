// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// This record is an implementation of the seev.001.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A notifying party, for example, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.
/// Usage
/// The MeetingNotification message is used to announce a shareholders meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.
/// To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.
/// To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(
    @"Scope|A notifying party, for example, an issuer, its agent or an intermediary, sends the MeetingNotification message to a party holding the right to vote, to announce a shareholders meeting.|Usage|The MeetingNotification message is used to announce a shareholders meeting, for example, it provides information on the participation details and requirements for the meeting, the vote parameters and the resolutions. The MeetingNotification message may also be used to announce an update.|To notify an update, the Amendment building block must be filled in. Any building block that is modified must be included in the amendment message. The information previously notified and not repeated in the amendment message remains valid.|To update the resolutions of the agenda, the complete list of resolutions must be repeated in the amendment message. The resolutions that are deleted should be assigned the status Withdrawn.|This message definition is intended for use with the Business Application Header."
)]
[IsoId("_xDAOX1tcEeSwKe7KuKvXhg")]
[DisplayName("Meeting Notification V")]
public record MeetingNotificationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.001.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.001.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information specific to an amendment.
    /// </summary>
    [IsoId("_xDJ_BVtcEeSwKe7KuKvXhg")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public AmendInformation1? Amendment { get; init; }

    /// <summary>
    /// Defines the global status of the event contained in the notification.
    /// </summary>
    [IsoId("_xDJ_B1tcEeSwKe7KuKvXhg")]
    [DisplayName("Notification Status")]
    [IsoXmlTag("NtfctnSts")]
    public required NotificationStatus2 NotificationStatus { get; init; }

    /// <summary>
    /// Specifies information about the meeting. This component contains meeting identifications, various deadlines, contact persons, electronic and postal locations for accessing information and proxy assignment parameters.
    /// </summary>
    [IsoId("_xDJ_CVtcEeSwKe7KuKvXhg")]
    [DisplayName("Meeting")]
    [IsoXmlTag("Mtg")]
    public required MeetingNotice4 Meeting { get; init; }

    /// <summary>
    /// Dates and details of the shareholders meeting.
    /// </summary>
    [IsoId("_xDJ_C1tcEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Details")]
    [IsoXmlTag("MtgDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<Meeting4> MeetingDetails { get; init; } = [];

    /// <summary>
    /// Specifies the institution that is the issuer of the security to which the meeting applies.
    /// </summary>
    [IsoId("_xDJ_D1tcEeSwKe7KuKvXhg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public required IssuerInformation2 Issuer { get; init; }

    /// <summary>
    /// Agents of the issuer.
    /// </summary>
    [IsoId("_xDJ_EVtcEeSwKe7KuKvXhg")]
    [DisplayName("Issuer Agent")]
    [IsoXmlTag("IssrAgt")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<IssuerAgent2> IssuerAgent { get; init; } = [];

    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_xDJ_E1tcEeSwKe7KuKvXhg")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition8> Security { get; init; } = [];

    /// <summary>
    /// Detailed information of a resolution proposed to the vote.
    /// </summary>
    [IsoId("_xDJ_FVtcEeSwKe7KuKvXhg")]
    [DisplayName("Resolution")]
    [IsoXmlTag("Rsltn")]
    [MinLength(0)]
    [MaxLength(1000)]
    public ValueList<Resolution3> Resolution { get; init; } = [];

    /// <summary>
    /// Specifies the conditions to be allowed to vote, the different voting methods and options, the voting deadlines and the parameters of the incentive premium.
    /// </summary>
    [IsoId("_xDJ_F1tcEeSwKe7KuKvXhg")]
    [DisplayName("Vote")]
    [IsoXmlTag("Vote")]
    public VoteParameters4? Vote { get; init; }

    /// <summary>
    /// Specifies the entitlement ratio and the different deadlines for calculating the entitlement.
    /// </summary>
    [IsoId("_xDJ_GVtcEeSwKe7KuKvXhg")]
    [DisplayName("Entitlement Specification")]
    [IsoXmlTag("EntitlmntSpcfctn")]
    public EntitlementAssessment3? EntitlementSpecification { get; init; }

    /// <summary>
    /// Specifies requirements relative to the use of Power of Attorney.
    /// </summary>
    [IsoId("_xDJ_G1tcEeSwKe7KuKvXhg")]
    [DisplayName("Power Of Attorney Requirements")]
    [IsoXmlTag("PwrOfAttnyRqrmnts")]
    public PowerOfAttorneyRequirements3? PowerOfAttorneyRequirements { get; init; }

    /// <summary>
    /// Provides additional narrative information about the corporate event.
    /// </summary>
    [IsoId("_xDJ_HVtcEeSwKe7KuKvXhg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateEventNarrative2? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_dkX0oVtoEeSwKe7KuKvXhg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingNotificationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingNotificationV05.
