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

namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.108.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeMarginDataReport message is sent by the report submitting entity to the trade repository (TR) to report the margins exchanged in relation to the derivative transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable.
/// </summary>
[Description(
    @"The DerivativesTradeMarginDataReport message is sent by the report submitting entity to the trade repository (TR) to report the margins exchanged in relation to the derivative transactions or sent by the trade repository (TR) to the authority or made available by the trade repository (TR) to the report submitting entity and the reporting counterparty as well as the entity responsible for reporting, if applicable."
)]
[IsoId("_pVUhYWmFEe2DRvVJM2Qy-g")]
[DisplayName("Derivatives Trade Margin Data Report V")]
public record DerivativesTradeMarginDataReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.108.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradMrgnDataRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.108.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Header information related to metadata of report message.
    /// </summary>
    [IsoId("_pVVIcWmFEe2DRvVJM2Qy-g")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required TradeReportHeader4 ReportHeader { get; init; }

    /// <summary>
    /// Set of data concerning the reporting trade.
    /// </summary>
    [IsoId("_pVVIc2mFEe2DRvVJM2Qy-g")]
    [DisplayName("Trade Data")]
    [IsoXmlTag("TradData")]
    public required TradeData55Choice_ TradeData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_pVVIdWmFEe2DRvVJM2Qy-g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since DerivativesTradeMarginDataReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeMarginDataReportV01.
