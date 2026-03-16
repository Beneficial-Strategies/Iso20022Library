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
/// This record is an implementation of the fxtr.031.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeCaptureReport message is sent by a trading system to a participant for notification and providing details of a treasury trade.
/// Usage
/// The report is sent by the trading system to the two trading parties after their trade has been executed.
/// The report can also be sent by the trading system to a trading parties to respond their inquiry (TradeCaptureRequest).
/// Note that multiple reports can be sent to respond one inquiry message.
/// The message may contains trade details and trading parties&apos; information.
/// </summary>
[Description(
    @"Scope|The ForeignExchangeTradeCaptureReport message is sent by a trading system to a participant for notification and providing details of a treasury trade.|Usage|The report is sent by the trading system to the two trading parties after their trade has been executed. |The report can also be sent by the trading system to a trading parties to respond their inquiry (TradeCaptureRequest). |Note that multiple reports can be sent to respond one inquiry message.|The message may contains trade details and trading parties' information."
)]
[IsoId("_OqvAMkRZEeSWxNI5mwqKGQ")]
[DisplayName("Foreign Exchange Trade Capture Report V")]
public record ForeignExchangeTradeCaptureReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.031.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.031.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Capture report message management information.
    /// </summary>
    [IsoId("_ZlYv4ERZEeSWxNI5mwqKGQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; }

    /// <summary>
    /// Identifies the capture report message.
    /// </summary>
    [IsoId("_gWVfQERZEeSWxNI5mwqKGQ")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public MessageIdentification1? ReportIdentification { get; init; }

    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_kvGPQERZEeSWxNI5mwqKGQ")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public TradePartyIdentification7? TradingSideIdentification { get; init; }

    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_t_XgwERZEeSWxNI5mwqKGQ")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public TradePartyIdentification7? CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Details of the treasury trade captured.
    /// </summary>
    [IsoId("_qakFwEU0EeS7YamWDFxbDA")]
    [DisplayName("Trade Detail")]
    [IsoXmlTag("TradDtl")]
    public Trade1? TradeDetail { get; init; }

    /// <summary>
    /// Reference of the report.
    /// </summary>
    [IsoId("_yvuZ4EU0EeS7YamWDFxbDA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public AdditionalReferences? Reference { get; init; }

    /// <summary>
    /// Indicates if this report is for responding to a capture request.
    /// </summary>
    [IsoId("__yMKoEU0EeS7YamWDFxbDA")]
    [DisplayName("Request Responder")]
    [IsoXmlTag("ReqRspndr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RequestResponder { get; init; }

    /// <summary>
    /// Indicates if this report is a rejection report for responding to a capture request.
    /// </summary>
    [IsoId("_E2SWoEU1EeS7YamWDFxbDA")]
    [DisplayName("Request Rejected")]
    [IsoXmlTag("ReqRjctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RequestRejected { get; init; }

    /// <summary>
    /// Reason of rejection.
    /// </summary>
    [IsoId("_HyozAEU1EeS7YamWDFxbDA")]
    [DisplayName("Query Reject Reason")]
    [IsoXmlTag("QryRjctRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? QueryRejectReason { get; init; }

    /// <summary>
    /// Indicates the total number of trades.
    /// </summary>
    [IsoId("_4M2w8EU0EeS7YamWDFxbDA")]
    [DisplayName("Total Number Trades")]
    [IsoXmlTag("TtlNbTrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? TotalNumberTrades { get; init; }

    /// <summary>
    /// Indicates if this report is the last report sent for responding to one capture request.
    /// </summary>
    [IsoId("_71d2YEU0EeS7YamWDFxbDA")]
    [DisplayName("Last Report Requested")]
    [IsoXmlTag("LastRptReqd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LastReportRequested { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IoQyQKHhEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ForeignExchangeTradeCaptureReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportV01.
