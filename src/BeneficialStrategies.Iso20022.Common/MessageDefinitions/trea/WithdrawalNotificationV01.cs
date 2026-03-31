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
/// This record is an implementation of the trea.013.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The WithdrawalNotification message is sent by a central system to notify the withdrawal of a trade which was previously notified to the receiver as an alleged trade.
/// Usage
/// The message is used to confirm the cancellation of a previously notified trade.
///
/// This message is obsolete please use WithdrawalNotificationV02 - fxtr.013.001.02
/// </summary>
[Description(
    @"Scope|The WithdrawalNotification message is sent by a central system to notify the withdrawal of a trade which was previously notified to the receiver as an alleged trade.|Usage|The message is used to confirm the cancellation of a previously notified trade.||This message is obsolete please use WithdrawalNotificationV02 - fxtr.013.001.02"
)]
[IsoId("_V5V16NE8Ed-BzquC8wXy7w_-1324281")]
[DisplayName("Withdrawal Notification V")]
public record WithdrawalNotificationV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.013.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "WdrwlNtfctnV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.013.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference assigned by the central matching system which is notifying the deletion of a previously reported trade.
    /// </summary>
    [IsoId("_V5e_0NE8Ed-BzquC8wXy7w_-2008623152")]
    [DisplayName("Matching System Unique Reference")]
    [IsoXmlTag("MtchgSysUnqRef")]
    public required MessageReference MatchingSystemUniqueReference { get; init; }
}

// Since WithdrawalNotificationV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to WithdrawalNotificationV01.
