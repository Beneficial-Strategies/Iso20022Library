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

namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MessageReject message is sent by a central system to notify the rejection of a previously received message.
/// Usage
/// The message provides specific information about the rejection reason.
/// </summary>
[Description(
    @"Scope|The MessageReject message is sent by a central system to notify the rejection of a previously received message.|Usage|The message provides specific information about the rejection reason."
)]
[IsoId("_8LH5WNE9Ed-BzquC8wXy7w_-1942533103")]
[DisplayName("Message Reject V")]
public record MessageRejectV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.002.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "admi.002.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.002.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Refers to the identification of the message previously received and for which the rejection is notified.
    /// </summary>
    [IsoId("_8LH5WdE9Ed-BzquC8wXy7w_-1383804009")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required MessageReference RelatedReference { get; init; }

    /// <summary>
    /// General information about the reason of the message rejection.
    /// </summary>
    [IsoId("_8LH5WtE9Ed-BzquC8wXy7w_-223860119")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectionReason2 Reason { get; init; }
}

// Since MessageRejectV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MessageRejectV01.
