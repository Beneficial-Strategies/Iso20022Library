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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.059.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The NotificationToReceiveStatusReport message is sent by an account servicing institution to an account owner or to a party acting on the account owner&apos;s behalf. It is used to notify the account owner about the status of one or more expected payments that were advised in a previous NotificationToReceive message.
/// Usage
/// The NotificationToReceiveStatusReport message is sent in response to a NotificationToReceive message and can be used in either a direct or a relay scenario. It is used to advise the account owner of receipt of the funds as expected. It is also used to notify the account owner of non-receipt of funds or of discrepancies in the funds received.
/// </summary>
[Description(
    @"Scope|The NotificationToReceiveStatusReport message is sent by an account servicing institution to an account owner or to a party acting on the account owner's behalf. It is used to notify the account owner about the status of one or more expected payments that were advised in a previous NotificationToReceive message.|Usage|The NotificationToReceiveStatusReport message is sent in response to a NotificationToReceive message and can be used in either a direct or a relay scenario. It is used to advise the account owner of receipt of the funds as expected. It is also used to notify the account owner of non-receipt of funds or of discrepancies in the funds received."
)]
[IsoId("_sZFgJWtdEeCY4-KZ9JEyUQ_-1390141251")]
[DisplayName("Notification To Receive Status Report V")]
public record NotificationToReceiveStatusReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.059.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnToRcvStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.059.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_sZZCIGtdEeCY4-KZ9JEyUQ_1005512460")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader44 GroupHeader { get; init; }

    /// <summary>
    /// Set of elements used to identify the original notification and to provide the status.
    /// </summary>
    [IsoId("_sZZCIWtdEeCY4-KZ9JEyUQ_122279173")]
    [DisplayName("Original Notification And Status")]
    [IsoXmlTag("OrgnlNtfctnAndSts")]
    public required OriginalNotification3 OriginalNotificationAndStatus { get; init; }
}

// Since NotificationToReceiveStatusReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NotificationToReceiveStatusReportV02.
