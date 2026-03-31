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
/// This record is an implementation of the seev.003.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends the MeetingEntitlementNotification to an issuer, its agent, an intermediary or an account owner to advise the entitlement in relation to a shareholders meeting.
/// Usage
/// This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place.
/// This entitlement message is sent by the account servicer or the registrar to an intermediary, the issuer&apos;s agent or the issuer. It is also sent between the account servicer and the account owner or the party holding the right to vote.
/// The message is also used to amend a previously sent MeetingEntitlementNotification. To notify an update, the RelatedReference must be included in the message.
/// This message definition is intended for use with the Business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer sends the MeetingEntitlementNotification to an issuer, its agent, an intermediary or an account owner to advise the entitlement in relation to a shareholders meeting.|Usage|This message is sent to advise the quantity of securities held by an account owner. The balance is specified for the securities for which the meeting is taking place.|This entitlement message is sent by the account servicer or the registrar to an intermediary, the issuer's agent or the issuer. It is also sent between the account servicer and the account owner or the party holding the right to vote.|The message is also used to amend a previously sent MeetingEntitlementNotification. To notify an update, the RelatedReference must be included in the message.|This message definition is intended for use with the Business Application Header."
)]
[IsoId("_xDAOGVtcEeSwKe7KuKvXhg")]
[DisplayName("Meeting Entitlement Notification V")]
public record MeetingEntitlementNotificationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.003.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgEntitlmntNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.003.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the meeting entitlement message to be modified.
    /// </summary>
    [IsoId("_xDAOHVtcEeSwKe7KuKvXhg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public MessageIdentification? RelatedReference { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_xDAOH1tcEeSwKe7KuKvXhg")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference7 MeetingReference { get; init; }

    /// <summary>
    /// Identifies the security for which the meeting is organised, the account and the positions of the security holder.
    /// </summary>
    [IsoId("_xDAOI1tcEeSwKe7KuKvXhg")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition9> Security { get; init; } = [];

    /// <summary>
    /// Defines the dates determining eligibility.
    /// </summary>
    [IsoId("_xDAOJVtcEeSwKe7KuKvXhg")]
    [DisplayName("Eligibility")]
    [IsoXmlTag("Elgblty")]
    public required EligibilityDates1 Eligibility { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nfrAIVtoEeSwKe7KuKvXhg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingEntitlementNotificationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingEntitlementNotificationV05.
