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

namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.008.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeStatusNotification message is sent by a central system to the participant to notify the current status of a foreign exchange trade in the system.|
/// Usage|
/// This ForeignExchangeTradeStatusNotification message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.
/// </summary>
[Description(
    @"Scope||The ForeignExchangeTradeStatusNotification message is sent by a central system to the participant to notify the current status of a foreign exchange trade in the system.||Usage||This ForeignExchangeTradeStatusNotification message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system."
)]
[IsoId("_mJeVGQM-Ee2nqoJcXIhTdw")]
[DisplayName("Foreign Exchange Trade Status Notification V")]
public record ForeignExchangeTradeStatusNotificationV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.008.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradStsNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.008.001.07";

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
    [IsoId("_mJeVGwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData15 TradeData { get; init; }

    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_mJeVHQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting7? RegulatoryReporting { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mJeVHwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeStatusNotificationV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeStatusNotificationV07.
