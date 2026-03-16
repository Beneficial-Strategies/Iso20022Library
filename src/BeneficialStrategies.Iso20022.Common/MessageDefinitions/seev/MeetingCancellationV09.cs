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
/// This record is an implementation of the seev.002.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel a previously announced meeting or to advise the withdrawal of a meeting.
/// Usage
/// The MeetingCancellation message is used to advise that the meeting has been cancelled by the account servicer or withdrawn by the issuer.
/// This message definition is intended for use with the Business Application Header (BAH).
/// </summary>
[Description(
    @"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel a previously announced meeting or to advise the withdrawal of a meeting.|Usage|The MeetingCancellation message is used to advise that the meeting has been cancelled by the account servicer or withdrawn by the issuer. |This message definition is intended for use with the Business Application Header (BAH)."
)]
[IsoId("_nIpWYTQ7Ee22Z83HpR5E8w")]
[DisplayName("Meeting Cancellation V")]
public record MeetingCancellationV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.002.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements to allow the unambiguous identification of a meeting.
    /// </summary>
    [IsoId("_nIpWaTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference10 MeetingReference { get; init; }

    /// <summary>
    /// Identification of the security for which the meeting was organised.
    /// </summary>
    [IsoId("_nIpWazQ7Ee22Z83HpR5E8w")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(1)]
    [MaxLength(200)]
    public ValueList<SecurityPosition17> Security { get; init; } = [];

    /// <summary>
    /// Justification for the cancellation.
    /// </summary>
    [IsoId("_nIpWbTQ7Ee22Z83HpR5E8w")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MeetingCancellationReason2 Reason { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nIpWbzQ7Ee22Z83HpR5E8w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MeetingCancellationV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingCancellationV09.
