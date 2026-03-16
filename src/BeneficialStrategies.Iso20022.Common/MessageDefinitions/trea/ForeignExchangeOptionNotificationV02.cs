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
/// This record is an implementation of the trea.012.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeOptionNotification message is sent by a central system to a participant to provide details of a foreign exchange option trade.
/// Usage
/// The notification is sent by the central settlement system to the two trading parties after it has received Create, Amend or Cancel messages from both. The message may also contain information on the settlement of the trade and/or premium.
/// </summary>
[Description(
    @"Scope|The ForeignExchangeOptionNotification message is sent by a central system to a participant to provide details of a foreign exchange option trade.|Usage|The notification is sent by the central settlement system to the two trading parties after it has received Create, Amend or Cancel messages from both. The message may also contain information on the settlement of the trade and/or premium."
)]
[IsoId("_QCIK6NE8Ed-BzquC8wXy7w_-2045814163")]
[DisplayName("Foreign Exchange Option Notification V")]
public record ForeignExchangeOptionNotificationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.012.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXOptnNtfctnV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.012.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies the trading side of the currency option trade which is reported.
    /// </summary>
    [IsoId("_QCIK6dE8Ed-BzquC8wXy7w_-28711885")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification4 TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_QCIK6tE8Ed-BzquC8wXy7w_-1363683318")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification4 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Provides information on the conditions of the option.
    /// </summary>
    [IsoId("_QCIK69E8Ed-BzquC8wXy7w_1138794159")]
    [DisplayName("Option Data")]
    [IsoXmlTag("OptnData")]
    public required OptionData2 OptionData { get; init; }

    /// <summary>
    /// Provides information on the status of a trade in a settlement system.
    /// </summary>
    [IsoId("_QCR74NE8Ed-BzquC8wXy7w_1207820711")]
    [DisplayName("Trade Status")]
    [IsoXmlTag("TradSts")]
    public required TradeStatus1 TradeStatus { get; init; }

    /// <summary>
    /// Provides information on the settlement of a trade.
    /// </summary>
    [IsoId("_QCR74dE8Ed-BzquC8wXy7w_949234653")]
    [DisplayName("Settlement Data")]
    [IsoXmlTag("SttlmData")]
    public SettlementData2? SettlementData { get; init; }
}

// Since ForeignExchangeOptionNotificationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeOptionNotificationV02.
