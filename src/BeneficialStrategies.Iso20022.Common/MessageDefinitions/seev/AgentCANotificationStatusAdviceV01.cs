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
/// This record is an implementation of the seev.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to report the status, or change in status, of a notification advice or notification cancellation request.
/// Usage
/// When this message is used to report the status of a notification advice then the building block Agent Corporate Action Notification Advice Identification must be present.
/// When this message is used to provide the status of a notification cancellation request then the building block Notification Cancellation Request Identification must be present.
/// </summary>
[Description(
    @"Scope|This message is sent by a CSD to an issuer (or its agent) to report the status, or change in status, of a notification advice or notification cancellation request.|Usage|When this message is used to report the status of a notification advice then the building block Agent Corporate Action Notification Advice Identification must be present.|When this message is used to provide the status of a notification cancellation request then the building block Notification Cancellation Request Identification must be present."
)]
[IsoId("_TReSOdEwEd-BzquC8wXy7w_-1525445298")]
[DisplayName("Agent CA Notification Status Advice V")]
public record AgentCANotificationStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "seev.011.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCANtfctnStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.011.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the status advice.
    /// </summary>
    [IsoId("_TReSOtEwEd-BzquC8wXy7w_-885544808")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification8 Identification { get; init; }

    /// <summary>
    /// Identification of the linked Agent CA Notification Advice for which a status is given.
    /// </summary>
    [IsoId("_TReSO9EwEd-BzquC8wXy7w_-867070991")]
    [DisplayName("Agent CA Notification Advice Identification")]
    [IsoXmlTag("AgtCANtfctnAdvcId")]
    public required DocumentIdentification8 AgentCANotificationAdviceIdentification { get; init; }

    /// <summary>
    /// Identification of the linked Agent CA Notification Cancellation Request for which a status is given.
    /// </summary>
    [IsoId("_TReSPNEwEd-BzquC8wXy7w_-853220988")]
    [DisplayName("Agent CA Notification Cancellation Request Identification")]
    [IsoXmlTag("AgtCANtfctnCxlReqId")]
    public required DocumentIdentification8 AgentCANotificationCancellationRequestIdentification { get; init; }

    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TRoDMNEwEd-BzquC8wXy7w_-1070148838")]
    [DisplayName("Corporate Action General Information")]
    [IsoXmlTag("CorpActnGnlInf")]
    public required CorporateActionInformation2 CorporateActionGeneralInformation { get; init; }

    /// <summary>
    /// Status of the Notification Cancellation Request sent by the issuer (agent).
    /// </summary>
    [IsoId("_TRoDMdEwEd-BzquC8wXy7w_-979644850")]
    [DisplayName("Notification Cancellation Request Status")]
    [IsoXmlTag("NtfctnCxlReqSts")]
    public required NotificationCancellationRequestStatus1Choice_ NotificationCancellationRequestStatus { get; init; }

    /// <summary>
    /// Status of the notification advice sent by the issuer (agent).
    /// </summary>
    [IsoId("_TRoDMtEwEd-BzquC8wXy7w_-982413026")]
    [DisplayName("Notification Advice Status")]
    [IsoXmlTag("NtfctnAdvcSts")]
    public required NotificationAdviceStatus1Choice_ NotificationAdviceStatus { get; init; }
}

// Since AgentCANotificationStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AgentCANotificationStatusAdviceV01.
