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
/// This record is an implementation of the fxtr.017.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeStatusAndDetails message is sent by a central system to the participant to provide notification of the status and details of a foreign exchange trade.|
/// Usage|
/// The notification is sent by a central settlement system to the two trading parties after it has received foreign exchange trade instructions from both.
/// </summary>
[Description(
    @"Scope||The ForeignExchangeTradeStatusAndDetails message is sent by a central system to the participant to provide notification of the status and details of a foreign exchange trade.||Usage||The notification is sent by a central settlement system to the two trading parties after it has received foreign exchange trade instructions from both."
)]
[IsoId("_rIwsQZR5Eeak6e8_Fc5fQg")]
[DisplayName("Foreign Exchange Trade Status And Details Notification V")]
public record ForeignExchangeTradeStatusAndDetailsNotificationV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.017.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradStsAndDtlsNtfctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.017.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the central system.
    /// </summary>
    [IsoId("_rIwsR5R5Eeak6e8_Fc5fQg")]
    [DisplayName("Status Details")]
    [IsoXmlTag("StsDtls")]
    public required TradeData14 StatusDetails { get; init; }

    /// <summary>
    /// General information related to the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsSZR5Eeak6e8_Fc5fQg")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement12 TradeInformation { get; init; }

    /// <summary>
    /// Party(ies) on the trading side of the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsS5R5Eeak6e8_Fc5fQg")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification6 TradingSideIdentification { get; init; }

    /// <summary>
    /// Party(ies) on the counterparty side of the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsTZR5Eeak6e8_Fc5fQg")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification6 CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsT5R5Eeak6e8_Fc5fQg")]
    [DisplayName("Trade Amounts")]
    [IsoXmlTag("TradAmts")]
    public required AmountsAndValueDate1 TradeAmounts { get; init; }

    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_rIwsUZR5Eeak6e8_Fc5fQg")]
    [DisplayName("Agreed Rate")]
    [IsoXmlTag("AgrdRate")]
    public required AgreedRate3 AgreedRate { get; init; }

    /// <summary>
    /// Provides the opening and fixing information for an NDF trade.
    /// </summary>
    [IsoId("_ncd-oKZqEea16Jw8SEVrDQ")]
    [DisplayName("Non Deliverable Forward Conditions")]
    [IsoXmlTag("NDFConds")]
    public NonDeliverableForwardConditions2? NonDeliverableForwardConditions { get; init; }

    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_rIwsU5R5Eeak6e8_Fc5fQg")]
    [DisplayName("Trading Side Settlement Instructions")]
    [IsoXmlTag("TradgSdSttlmInstrs")]
    public SettlementParties29? TradingSideSettlementInstructions { get; init; }

    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_rIwsVZR5Eeak6e8_Fc5fQg")]
    [DisplayName("Counterparty Side Settlement Instructions")]
    [IsoXmlTag("CtrPtySdSttlmInstrs")]
    public SettlementParties29? CounterpartySideSettlementInstructions { get; init; }

    /// <summary>
    /// Additional Information about the foreign exchange trade.
    /// </summary>
    [IsoId("_rIwsV5R5Eeak6e8_Fc5fQg")]
    [DisplayName("General Information")]
    [IsoXmlTag("GnlInf")]
    public GeneralInformation5? GeneralInformation { get; init; }

    /// <summary>
    /// Details of the split trade.
    /// </summary>
    [IsoId("_rIwsWZR5Eeak6e8_Fc5fQg")]
    [DisplayName("Split Trade Information")]
    [IsoXmlTag("SpltTradInf")]
    public SplitTradeDetails3? SplitTradeInformation { get; init; }

    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_rIwsW5R5Eeak6e8_Fc5fQg")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    public RegulatoryReporting6? RegulatoryReporting { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rIwsXZR5Eeak6e8_Fc5fQg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeStatusAndDetailsNotificationV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeStatusAndDetailsNotificationV04.
