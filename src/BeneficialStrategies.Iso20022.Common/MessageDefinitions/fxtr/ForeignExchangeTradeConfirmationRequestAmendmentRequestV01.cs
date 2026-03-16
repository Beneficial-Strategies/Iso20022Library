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
/// This record is an implementation of the fxtr.035.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeConfirmationRequestAmendmentRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.
///
/// Usage
/// The request is sent by the market participants to the CMU after the confirmation is requested.
/// </summary>
[Description(
    @"Scope|The ForeignExchangeTradeConfirmationRequestAmendmentRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.||Usage|The request is sent by the market participants to the CMU after the confirmation is requested."
)]
[IsoId("_orQF4IHdEeSY3ulMDfpmvA")]
[DisplayName("Foreign Exchange Trade Confirmation Request Amendment Request V")]
public record ForeignExchangeTradeConfirmationRequestAmendmentRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.035.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReqAmdmntReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.035.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Message management information.
    /// </summary>
    [IsoId("_yesV4IHdEeSY3ulMDfpmvA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; }

    /// <summary>
    /// Identifies the amendment request messge.
    /// </summary>
    [IsoId("_ywTqUIHdEeSY3ulMDfpmvA")]
    [DisplayName("Amendment Request Identification")]
    [IsoXmlTag("AmdmntReqId")]
    public required MessageIdentification1 AmendmentRequestIdentification { get; init; }

    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_zF5f0IHdEeSY3ulMDfpmvA")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public TradePartyIdentification7? TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_aVIqwIdVEeS8A78Q2OnhsA")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public TradePartyIdentification7? CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Details of the treasury trade confirmed.
    /// </summary>
    [IsoId("_zpFFYIHdEeSY3ulMDfpmvA")]
    [DisplayName("Trade Detail")]
    [IsoXmlTag("TradDtl")]
    public required Trade2 TradeDetail { get; init; }

    /// <summary>
    /// Period of the inquiry.
    /// </summary>
    [IsoId("_1bgsUIHdEeSY3ulMDfpmvA")]
    [DisplayName("Query Period")]
    [IsoXmlTag("QryPrd")]
    public required Period4 QueryPeriod { get; init; }

    /// <summary>
    /// Number which the query results will start from.
    /// </summary>
    [IsoId("_2S1V4IHdEeSY3ulMDfpmvA")]
    [DisplayName("Query Start Number")]
    [IsoXmlTag("QryStartNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText QueryStartNumber { get; init; }

    /// <summary>
    /// Specifies the inquiry status of the trade.
    /// </summary>
    [IsoId("_ZbwkcKaeEeSR8qifggAitQ")]
    [DisplayName("Query Trade Status")]
    [IsoXmlTag("QryTradSts")]
    public required QueryTradeStatus1Code QueryTradeStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_gyxZAKHiEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeConfirmationRequestAmendmentRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestAmendmentRequestV01.
