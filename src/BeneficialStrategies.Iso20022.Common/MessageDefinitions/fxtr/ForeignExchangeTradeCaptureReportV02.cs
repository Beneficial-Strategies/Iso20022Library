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
/// This record is an implementation of the fxtr.031.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_KI20O3fYEe2I4Iip2NEM0A")]
[DisplayName("Foreign Exchange Trade Capture Report V02")]
public record ForeignExchangeTradeCaptureReportV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.031.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.031.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Counterparty Side Identification.
    /// </summary>
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public TradePartyIdentification9? CounterpartySideIdentification { get; init; }

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; }

    /// <summary>
    /// Last Report Requested.
    /// </summary>
    [DisplayName("Last Report Requested")]
    [IsoXmlTag("LastRptReqd")]
    public IsoTrueFalseIndicator? LastReportRequested { get; init; }

    /// <summary>
    /// Query Reject Reason.
    /// </summary>
    [DisplayName("Query Reject Reason")]
    [IsoXmlTag("QryRjctRsn")]
    public IsoMax35Text? QueryRejectReason { get; init; }

    /// <summary>
    /// Reference.
    /// </summary>
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public AdditionalReferences2? Reference { get; init; }

    /// <summary>
    /// Report Identification.
    /// </summary>
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public MessageIdentification1? ReportIdentification { get; init; }

    /// <summary>
    /// Request Rejected.
    /// </summary>
    [DisplayName("Request Rejected")]
    [IsoXmlTag("ReqRjctd")]
    public IsoTrueFalseIndicator? RequestRejected { get; init; }

    /// <summary>
    /// Request Responder.
    /// </summary>
    [DisplayName("Request Responder")]
    [IsoXmlTag("ReqRspndr")]
    public required IsoTrueFalseIndicator RequestResponder { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Total Number Trades.
    /// </summary>
    [DisplayName("Total Number Trades")]
    [IsoXmlTag("TtlNbTrds")]
    public IsoNumber? TotalNumberTrades { get; init; }

    /// <summary>
    /// Trade Detail.
    /// </summary>
    [DisplayName("Trade Detail")]
    [IsoXmlTag("TradDtl")]
    public Trade7? TradeDetail { get; init; }

    /// <summary>
    /// Trading Side Identification.
    /// </summary>
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public TradePartyIdentification9? TradingSideIdentification { get; init; }
}

// Since ForeignExchangeTradeCaptureReportV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportV02.
