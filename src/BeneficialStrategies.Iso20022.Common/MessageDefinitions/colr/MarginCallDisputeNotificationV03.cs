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

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.009.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The MarginCallDisputeNotification message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager to acknowledge the notification of the dispute (either full or partial dispute) of the MarginCallRequest. The message will detail the amount of the dispute and the reason.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// When there is a dispute by the collateral giver to the collateral taker a MarginCallDisputeNotification message is sent with the disputed amount (full or partial) stating the reason why the margin call is being disputed.
/// </summary>
[Description(
    @"Scope|The MarginCallDisputeNotification message is sent by the collateral taker or its collateral manager to the collateral giver or its collateral manager to acknowledge the notification of the dispute (either full or partial dispute) of the MarginCallRequest. The message will detail the amount of the dispute and the reason.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|When there is a dispute by the collateral giver to the collateral taker a MarginCallDisputeNotification message is sent with the disputed amount (full or partial) stating the reason why the margin call is being disputed."
)]
[IsoId("_InD5oV9MEeSMgPeFpRHeJw")]
[DisplayName("Margin Call Dispute Notification V")]
public record MarginCallDisputeNotificationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.009.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MrgnCallDsptNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.009.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_InD5o19MEeSMgPeFpRHeJw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_InD5pV9MEeSMgPeFpRHeJw")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation3 Obligation { get; init; }

    /// <summary>
    /// Details of the dispute notification.
    /// </summary>
    [IsoId("_InD5p19MEeSMgPeFpRHeJw")]
    [DisplayName("Dispute Notification")]
    [IsoXmlTag("DsptNtfctn")]
    public required DisputeNotification1Choice_ DisputeNotification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_InD5qV9MEeSMgPeFpRHeJw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since MarginCallDisputeNotificationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MarginCallDisputeNotificationV03.
