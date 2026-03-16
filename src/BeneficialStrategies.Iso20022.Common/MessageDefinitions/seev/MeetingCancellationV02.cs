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
/// This record is an implementation of the seev.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.
/// Usage
/// The MeetingCancellation message is used in two different situations.
/// First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.
/// Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present.
/// </summary>
[Description(
    @"Scope|The MeetingCancellation message is sent by the party that sent the MeetingNotification message to the original receiver. It is sent to cancel the previous MeetingNotification message or to advise the cancellation of a meeting.|Usage|The MeetingCancellation message is used in two different situations.|First, it is used to cancel a previously sent MeetingNotification message. In this case, the MessageCancellation, the MeetingReference and the Reason building blocks need to be present.|Second, it is used to advise that the meeting is cancelled. In this case, only the MeetingReference and Reason building blocks need to be present."
)]
[IsoId("_TlJcItEwEd-BzquC8wXy7w_-976963352")]
[DisplayName("Meeting Cancellation V")]
public record MeetingCancellationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.002.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MtgCxl";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.002.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the cancellation message.
    /// </summary>
    [IsoId("_TlJcI9EwEd-BzquC8wXy7w_-1270178957")]
    [DisplayName("Cancellation Identification")]
    [IsoXmlTag("CxlId")]
    public required MessageIdentification1 CancellationIdentification { get; init; }

    /// <summary>
    /// Information indicating that the cancellation of a message previously sent is requested (and not the cancellation of the meeting).
    /// </summary>
    [IsoId("_TlJcJNEwEd-BzquC8wXy7w_-976963274")]
    [DisplayName("Message Cancellation")]
    [IsoXmlTag("MsgCxl")]
    public AmendInformation1? MessageCancellation { get; init; }

    /// <summary>
    /// Series of elements which allow to identify a meeting.
    /// </summary>
    [IsoId("_TlJcJdEwEd-BzquC8wXy7w_-976963350")]
    [DisplayName("Meeting Reference")]
    [IsoXmlTag("MtgRef")]
    public required MeetingReference2 MeetingReference { get; init; }

    /// <summary>
    /// Party notifying the cancellation of the meeting.
    /// </summary>
    [IsoId("_TlJcJtEwEd-BzquC8wXy7w_-976963316")]
    [DisplayName("Notifying Party")]
    [IsoXmlTag("NtifngPty")]
    public PartyIdentification9Choice_? NotifyingParty { get; init; }

    /// <summary>
    /// Identifies the security for which the meeting was organised.
    /// </summary>
    [IsoId("_TlJcJ9EwEd-BzquC8wXy7w_-976963334")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    [MinLength(0)]
    [MaxLength(200)]
    public ValueList<SecurityPosition5> Security { get; init; } = [];

    /// <summary>
    /// Defines the justification for the cancellation.
    /// </summary>
    [IsoId("_TlJcKNEwEd-BzquC8wXy7w_-976963291")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MeetingCancellationReason1 Reason { get; init; }
}

// Since MeetingCancellationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MeetingCancellationV02.
