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
/// This record is an implementation of the trea.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The NonDeliverableForwardNotification message is sent by a central system to a participant to provide details of a non deliverable forward trade.
/// Usage
/// The notification is sent by a central settlement system to the two trading parties after it has received create, amend or cancel messages from both. The message may also contain information on the settlement of the trade.
/// </summary>
[Description(
    @"Scope|The NonDeliverableForwardNotification message is sent by a central system to a participant to provide details of a non deliverable forward trade.|Usage|The notification is sent by a central settlement system to the two trading parties after it has received create, amend or cancel messages from both. The message may also contain information on the settlement of the trade."
)]
[IsoId("_URegMNE8Ed-BzquC8wXy7w_1248981968")]
[DisplayName("Non Deliverable Forward Notification V")]
public record NonDeliverableForwardNotificationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.007.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NDFNtfctnV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.007.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Specifies the trading side of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_URegMdE8Ed-BzquC8wXy7w_942299240")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification3 TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_URegMtE8Ed-BzquC8wXy7w_945996128")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Set of data specified for the opening of a non deliverable trade.
    /// </summary>
    [IsoId("_URegM9E8Ed-BzquC8wXy7w_159065050")]
    [DisplayName("Opening Data")]
    [IsoXmlTag("OpngData")]
    public OpeningData2? OpeningData { get; init; }

    /// <summary>
    /// Set of data specified for the valuation of a non deliverable trade.
    /// </summary>
    [IsoId("_URegNNE8Ed-BzquC8wXy7w_1474183734")]
    [DisplayName("Valuation Data")]
    [IsoXmlTag("ValtnData")]
    public ClosingData2? ValuationData { get; init; }

    /// <summary>
    /// Provides information on the status of a trade in a central system.
    /// </summary>
    [IsoId("_URegNdE8Ed-BzquC8wXy7w_1332886078")]
    [DisplayName("Trade Information And Status")]
    [IsoXmlTag("TradInfAndSts")]
    public required TradeStatus1 TradeInformationAndStatus { get; init; }

    /// <summary>
    /// Provides information on the settlement of a trade.
    /// </summary>
    [IsoId("_URoRMNE8Ed-BzquC8wXy7w_941311999")]
    [DisplayName("Settlement Data")]
    [IsoXmlTag("SttlmData")]
    public SettlementData2? SettlementData { get; init; }
}

// Since NonDeliverableForwardNotificationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NonDeliverableForwardNotificationV02.
