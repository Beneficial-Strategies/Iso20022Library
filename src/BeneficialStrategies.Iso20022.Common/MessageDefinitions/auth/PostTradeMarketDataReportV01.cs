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
/// This record is an implementation of the auth.124.001.01 ISO standard message type.
/// The PostTradeMarketDataReport message is sent by the Trading Venue and the Approved Publication Arrangement to the Consolidated Tape Provider, which disseminates it to their users in accordance with local regulations. The PostTradeMarketDataReport message contains post-trade transparency data, including key information such as the instrument identifier, transaction price, quantity, execution timestamp, and publication time.
/// </summary>
[Description(
    @"The PostTradeMarketDataReport message is sent by the Trading Venue and the Approved Publication Arrangement to the Consolidated Tape Provider, which disseminates it to their users in accordance with local regulations. The PostTradeMarketDataReport message contains post-trade transparency data, including key information such as the instrument identifier, transaction price, quantity, execution timestamp, and publication time."
)]
[IsoId("_mIhoMGIfEfCeoPFCHQnhvA")]
[DisplayName("Post Trade Market Data Report V01")]
public record PostTradeMarketDataReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.124.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PstTradMktDataRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.124.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides general information on the post trade core output data report.
    /// </summary>
    [IsoId("_Cl_HUGIgEfCeoPFCHQnhvA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public SecuritiesMarketReportHeader5? ReportHeader { get; init; }

    /// <summary>
    /// Report related to the post-trade transparency data for equity and bond instruments.
    /// </summary>
    [IsoId("_X8PTMGIgEfCeoPFCHQnhvA")]
    [DisplayName("Post Trade Report")]
    [IsoXmlTag("PstTradRpt")]
    [MinLength(1)]
    public ValueList<PostTradeReport1Choice_> PostTradeReport { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_H6g8AGIgEfCeoPFCHQnhvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
