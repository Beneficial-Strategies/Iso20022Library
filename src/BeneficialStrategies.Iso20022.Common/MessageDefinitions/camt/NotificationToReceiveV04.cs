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
/// This record is an implementation of the camt.057.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The NotificationToReceive message is sent by an account owner or by a party acting on the account owner&apos;s behalf to one of the account owner&apos;s account servicing institutions. It is an advance notice that the account servicing institution will receive funds to be credited to the account of the account owner.
/// Usage
/// The NotificationToReceive message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario.
/// </summary>
[Description(
    @"Scope|The NotificationToReceive message is sent by an account owner or by a party acting on the account owner's behalf to one of the account owner's account servicing institutions. It is an advance notice that the account servicing institution will receive funds to be credited to the account of the account owner.|Usage|The NotificationToReceive message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario."
)]
[IsoId("_VJ9wERPeEeSVo-TFVwFHvA")]
[DisplayName("Notification To Receive V")]
public record NotificationToReceiveV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.057.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnToRcv";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.057.001.04";

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
    [IsoId("_VJ9wExPeEeSVo-TFVwFHvA")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader59 GroupHeader { get; init; }

    /// <summary>
    /// Set of elements used to provide further details on the account notification.
    /// </summary>
    [IsoId("_VJ9wFRPeEeSVo-TFVwFHvA")]
    [DisplayName("Notification")]
    [IsoXmlTag("Ntfctn")]
    public required AccountNotification10 Notification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_VJ9wFxPeEeSVo-TFVwFHvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since NotificationToReceiveV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NotificationToReceiveV04.
