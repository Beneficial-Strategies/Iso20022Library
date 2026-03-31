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

namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// This record is an implementation of the trea.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusNotification message is sent by a central system to a participant to notify the current status of a trade in the system.|Usage
/// This message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.
///
///
/// This message is obsolete please use ForeignExchangeAndDerivativeTradeStatusNotificationV03 - fxtr.008.001.03
/// </summary>
[Description(
    @"Scope|The StatusNotification message is sent by a central system to a participant to notify the current status of a trade in the system.|Usage|This message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.|||This message is obsolete please use ForeignExchangeAndDerivativeTradeStatusNotificationV03 - fxtr.008.001.03"
)]
[IsoId("_VgTq09E8Ed-BzquC8wXy7w_1259743081")]
[DisplayName("Status Notification V")]
public record StatusNotificationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.008.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "trea.008.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.008.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides information on the status of a trade in a system.
    /// </summary>
    [IsoId("_VgTq1NE8Ed-BzquC8wXy7w_-575229954")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData1 TradeData { get; init; }
}

// Since StatusNotificationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusNotificationV02.
