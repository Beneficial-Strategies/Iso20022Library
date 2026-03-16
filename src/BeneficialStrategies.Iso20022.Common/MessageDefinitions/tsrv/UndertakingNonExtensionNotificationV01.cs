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

namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingNonExtensionNotification message is sent by the party that issued the undertaking to the beneficiary, either directly or via one or more advising parties, to notify it of the non-extension of the referenced undertaking beyond the current expiry date.
/// </summary>
[Description(
    @"The UndertakingNonExtensionNotification message is sent by the party that issued the undertaking to the beneficiary, either directly or via one or more advising parties, to notify it of the non-extension of the referenced undertaking beyond the current expiry date."
)]
[IsoId("_9i_O8nltEeG7BsjMvd1mEw_-188871383")]
[DisplayName("Undertaking Non Extension Notification V")]
public record UndertakingNonExtensionNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.011.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgNonXtnsnNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.011.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Details of the non-extension notification.
    /// </summary>
    [IsoId("_9i_O83ltEeG7BsjMvd1mEw_1181398282")]
    [DisplayName("Undertaking Non Extension Notification Details")]
    [IsoXmlTag("UdrtkgNonXtnsnNtfctnDtls")]
    public required UndertakingNonExtensionStatusAdvice1 UndertakingNonExtensionNotificationDetails { get; init; }

    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9i_O9HltEeG7BsjMvd1mEw_-676227762")]
    [DisplayName("Digital Signature")]
    [IsoXmlTag("DgtlSgntr")]
    public PartyAndSignature2? DigitalSignature { get; init; }
}

// Since UndertakingNonExtensionNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingNonExtensionNotificationV01.
