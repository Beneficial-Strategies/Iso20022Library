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
/// This record is an implementation of the fxtr.030.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.
/// </summary>
[Description(
    @"Scope||The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades."
)]
[IsoId("_mJe8YQM-Ee2nqoJcXIhTdw")]
[DisplayName("Foreign Exchange Trade Bulk Status Notification V")]
public record ForeignExchangeTradeBulkStatusNotificationV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.030.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradBlkStsNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.030.001.05";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information on the status of the trade in the central system.
    /// </summary>
    [IsoId("_mJe8ZQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Status Details")]
    [IsoXmlTag("StsDtls")]
    public required TradeData12 StatusDetails { get; init; }

    /// <summary>
    /// Identifies one or more trades for which the status notification is sent.
    /// </summary>
    [IsoId("_mJe8ZwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData40 TradeData { get; init; }

    /// <summary>
    /// Page number of the message (within the status report) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_mJe8aQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mJe8awM-Ee2nqoJcXIhTdw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeBulkStatusNotificationV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeBulkStatusNotificationV05.
